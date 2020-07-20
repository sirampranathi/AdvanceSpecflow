using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.FeaturefileSteps
{
    [Binding]
    public class TabsSteps

    {
        #region Language
        [Given(@"Click on Language tab")]
        public void GivenClickOnLanguageTab()
        {
            Profile.Navigatetolanguage();

        }

        [Given(@"Click on addnew button")]
        public void GivenClickOnAddnewButton()
        {
            Profile.Langadd();
        }

        [When(@"Enter new language details")]
        public void WhenEnterNewLanguageDetails()
        {
            Profile.AddNewLanguage();
        }

        [Then(@"verify new language is added")]
        public void ThenVerifyNewLanguageIsAdded()
        {
            Profile.VerifyAddedLanguage();
        }

        [Given(@"Click on edit button")]
        public void Clickoneditbutton()
        {
            Profile.Langedit();
        }
        [When(@"Update  language details")]
        public void Updatelanguagedetails()
        {
            Profile.Langup();
        }

        [Then(@"Verify record updated")]
        public void Verifyrecordupdated()
        {
            Profile.VerifyEditedLanguage();
        }
        [Given(@"Click on delete button")]
        public void Clickondeletebutton()
        {
            Profile.DeleteLanguage();

        }
        [Then(@"Verify record is deleted")]
        public void Verifyrecordisdeleted()
        {
            Profile.VerifyDeleteLanguage();
        }
        #endregion

        #region skill
        [Given(@"Click on Skill tab in profile")]
        public void GivenClickOnSkillTabinprofile()
        {
            Profile.Navigatetoskills();
        }

        [Given(@"Click on addnew skill record")]
        public void GivenClickOnAddnewskillrecord()
        {
            Profile.Addclick();
        }

        [When(@"Enter new Skills details and click add")]
        public void WhenEnternewSkillsDetailsAndClickAdd()
        {
            Profile.Addnewskill();
        }

        [Then(@"Verify new skill record is added")]
        public void ThenVerifyNewskillrecordIsAdded()
        {
            Profile.VerifyAddedSkill();
        }
        [Given(@"Click on edit Skill button")]
        public void Clickoneditskillbutton()
        {
            Profile.EditSkillrecord();
        }

        [When(@"Update Skill and click update")]
        public void UpdateSkillandclickupdate()
        {
            Profile.Skillchg();
        }

        [Then(@"Verify skill is updated")]
        public void Verifyskillisupdated()
        {
            Profile.Verifyskilledit();
        }
        [Given(@"Click on delete Skill button")]
        public void ClickondeleteSkillbutton()
        {
            Profile.Skilldelete();
        }

        [Then(@"Verify skill is deleted")]
        public void Verifyskillisdeleted()
        {
            Profile.Verifyskilldeleted();

        }
        #endregion





    }
}

    
    

