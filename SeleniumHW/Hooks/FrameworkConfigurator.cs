using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Framework_Marina.Hooks
{
    [Binding]
    public class FrameworkConfigurator
    {
        protected static IWebDriver driver;
        protected static WebDriverWait wait;
        protected static WebDriverWait customWait;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ScenarioContext scenarioContext;
        private static ExtentReports extent;

        [BeforeScenario]
        public static void DriverSetup()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            options.AddArguments("--incognito");
            options.AddArguments("--ash-enable-night-light");
            options.AddArguments("--disable-translate");
            options.AddArguments("--restore-last-session");
            options.AddArguments("--dns-prefetch-disable");
            options.AddArguments("--safebrowsing-enable-enhanced-protection");
            options.AddArguments("--ignore-certificate-errors");

            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            customWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);


        }
        [AfterScenario]
        public static void TestStop()
        {
                //driver.Close();
                driver.Quit();
                driver.Dispose();
        }

        public IWebDriver GetWebDriver() { return driver; }

        public WebDriverWait GetDriverWait() { return wait; }

        public WebDriverWait GetDriverCustomWait() { return customWait; }


        public void ThreadSleep(int msToWait = 1000)
        {
            Thread.Sleep(msToWait);
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            //Initialize Extent report before test starts
            var htmlReporter = new ExtentHtmlReporter(@"/Users/dumitrugrati/Downloads/Framework/HTML_ReportExtentReport.html");

            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }

        [BeforeFeature]
       
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }


        [AfterStep]
        
        public static void InsertReportSteps()
        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {

                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }
            else if (ScenarioStepContext.Current.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            }

        }
    }
}
