using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using AventStack.ExtentReports;
using System;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using AventStack.ExtentReports.Reporter;

using System.Reflection;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
        public static ExtentTest test;

        public static Boolean Signin = true;

        //Global Variable for Extend report
        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentHtmlReporter _extenthtmlReporter;
        private static ExtentTest scenario;
        private static ExtentTest feature;
        private static ExtentReports _extentReports;

       #region Before steps
        [BeforeTestRun]
        public static void InitializeReport()
        {
            //Initialize Extent report before test starts
            _extenthtmlReporter = new ExtentHtmlReporter(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\TestReports\Extentreport\");
            //htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            //Attach report to reporter
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extenthtmlReporter);
        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
            if(null!=featurecontext)
            {
               feature = _extentReports.CreateTest<Feature>(featurecontext.FeatureInfo.Title,
                                                  featurecontext.FeatureInfo.Description);

            }

        }
        [BeforeScenario]
        public void Setup(ScenarioContext scenarioContext)
        {

            Initialize();


            if (Signin)
            {
                /*_2LoginSteps.GivenUserLaunchTheWebsite();
                  _2LoginSteps.GivenClickOnSigninButton();
                  _2LoginSteps.WhenUserEnterLoginDetails();
                  _2LoginSteps.ThenClickOnLoginButton();*/
              
                SignIn.Launchurl();
                SignIn.SigninClick();
                SignIn.SigninStep();
                SignIn.LoginClick();
            }
            else
            {
                Signup.register();
            }
            if (null != scenarioContext)
            {
                _scenarioContext = scenarioContext;
                scenario = feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title,
                                             _scenarioContext.ScenarioInfo.Description);

            }

        }
        #endregion

        #region Aftersteps

        [AfterStep]

        public void InsertReportingSteps()
        {


            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;
            
            switch(scenarioBlock)
            {
                case ScenarioBlock.Given:
                  
                    if(_scenarioContext.TestError!=null)
                    {
                        scenario.CreateNode<Given>(_scenarioContext.TestError.Message).Fail("\n"+
                            _scenarioContext.TestError.StackTrace);

                    }
                    else
                    {
                        scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Pass("");

                    }
                    break;
                case ScenarioBlock.When:
                    
                    if (_scenarioContext.TestError != null)
                    {
                        scenario.CreateNode<When>(_scenarioContext.TestError.Message).Fail("\n" +
                            _scenarioContext.TestError.StackTrace);

                    }
                    else
                    {

                        scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    }
                 break;
                case ScenarioBlock.Then:

                    if (_scenarioContext.TestError != null)
                    {
                        scenario.CreateNode<Then>(_scenarioContext.TestError.Message).Fail("\n" +
                            _scenarioContext.TestError.StackTrace);

                    }
                    else
                    {
                        scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    }
                 break;
                default:

                    if (_scenarioContext.TestError != null)
                    {
                        scenario.CreateNode<And>(_scenarioContext.TestError.Message).Fail("\n" +
                            _scenarioContext.TestError.StackTrace);

                    }
                    else
                    {

                        scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    }
                    break;
           }
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            _extentReports.Flush();
        }


        [AfterScenario]
      public void TearDown()
      {
       //  String image =CommonMethods.SaveScreenshot(Driver.driver,"Extentreport");
        // test.Log(Status.Info, "Image example: " + image);

            //Driver.driver.Close();
            Driver.driver.Quit();

        }

    }
}
#endregion
