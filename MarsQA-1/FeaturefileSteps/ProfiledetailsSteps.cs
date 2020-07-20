using AventStack.ExtentReports.Gherkin.Model;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Specialized;
using TechTalk.SpecFlow;

namespace MarsQA_1.FeaturefileSteps
{
    [Binding]
    public class ProfiledetailsSteps
    {
        #region Description
        [Given(@"Click on Description edit button")]
        public void GivenClickOnDescriptionEditButton()
        {
            Profile.EditDescription();
        }

        [When(@"User enter the text in description box")]
        public void WhenUserEnterTheTextInDescriptionBox()
        {
            Profile.Entertext();
        }

        [Then(@"Click save and the text is saved")]
        public void ThenClickSaveAndTheTextIsSaved()
        {
            Profile.Verifytextsaved();
        }
        #endregion

        #region Title name

        [Given(@"Click on name dropdown")]
        public void GivenClickonnamedropdown()
        {
            Profile.Dropdownclick();
        }
        [When(@"Enter Firstname and lastname")]
        public void WhenEnterFirstnameandlastname()
        {
            Profile.Enterusername();
        }
        [Then(@"Click on save and name is added")]
        public void ThenClickonsaveandnameisadded()
        {
            Profile.Savename();
            Profile.Verifytitle();
        }
        #endregion

        #region Available time
        [Given(@"Click Availabilty details")]
      public void ClickAvailabilitydetails()
        {
            Profile.Availableclick();

        }

     [When(@"select the available timings")]
     public void Selecttheavailabletimings()
        {

            Profile.Availabletime();
        }
     [Then (@"Availabity is  added")]
     public void Availablityisadded()
        {
            Profile.VerifyAvailbilityadded();
        }
        #endregion

        #region Hours

        [Given (@"Click Hours details")]
        public void ClickHoursdetails()
        {
            Profile.Hoursclick();

        }

        [When (@"select hours needed")]
      public void Selecthoursneeded()
        {
            Profile.Hoursneed();

        }

        [Then (@"Hours needed are  added")]
        public void Hoursneededareadded()
        {
            Profile.Verifyhoursadded();
        }
        #endregion
  
        #region Target earn
        [Given (@"Click Earn Target details")]
        
         public void ClickTargetdetails()
        {
            Profile.Earnclick();
         }

        [When(@"select target amount")]
        public void Selecttargetamount()

        {
            Profile.Tgtearn();
        }
        [Then(@"Target amount is added")]
        public void Targetamountisadded()
        {
            Profile.Verifytargetadded();
        }
        #endregion

        #region Search skill
       
    [Given(@"Click on searchlink button")]
       public void Clickonsearchlinkbutton()
        {
            Profile.Searchclick();
        }
     [Given(@"Select Catogery")]
        public void Selectcatogery()
        {
            Profile.Catsearch();
        }

    [When (@"Select SubCategory")]
        public void Selectsubcategory()
        {
            Profile.Subcatsearch();
        }
    [When (@"Select filter in searchpage")]
        public void Selectfilterinsearchpage()
        {
            Profile.Filter();
        }
    [Then (@"Select the record")]
        public void Selecttherecord()
        {

        }
        #endregion
    }
}
