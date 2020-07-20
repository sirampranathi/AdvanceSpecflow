using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Linq;
using System.Threading;


namespace MarsQA_1.SpecflowPages.Pages
{
    class Profile
    {
        #region Description elements
        //Click on edit Description Elements
        private static IWebElement DescriptionEditIcon => Driver.driver.FindElement(By.XPath("//h3[@class='ui dividing header']//span[@class='button']"));
        //Enter text
        private static IWebElement DescriptionTextField => Driver.driver.FindElement(By.XPath("//textarea[@name='value']"));
        //Click save text
        private static IWebElement Descriptionsave => Driver.driver.FindElement(By.XPath("//button[@type='button']"));
        #endregion

        #region Title elements
        //Click on name Dropdown
        private static IWebElement Dropdown => Driver.driver.FindElement(By.XPath("(//i[@class='dropdown icon'])[2]"));

        //Enter Firstname
        private static IWebElement Firstname => Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='firstName']"));
        //Enter Lastname
        private static IWebElement Lastname => Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='lastName']"));
        //Click on Save
        private static IWebElement Save => Driver.driver.FindElement(By.XPath("(//button[@class='ui teal button' and text()='Save'])[1]"));
        #endregion

        #region availability elements
        //Select Availability
        private static IWebElement Availability => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[1]"));
        private static IWebElement Type => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyType']"));
        //Select  available Hours
        private static IWebElement Hours => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[2]"));
        private static IWebElement Availablehours => Driver.driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']"));
        //Select Earn target
        private static IWebElement Earn => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[3]"));
        private static IWebElement Targetearn => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyTarget']"));

        #endregion

        #region Language element
        //Click on language
        private static IWebElement Languagetab => Driver.driver.FindElement(By.XPath("//a[@data-tab='first' and text()='Languages']"));
        //Add New button for Language
        private static IWebElement LanguageAddNew => Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//div[@class='ui teal button '])[1]"));

        //Add New Language text field
        private static IWebElement AddLanguage => Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//input[@placeholder='Add Language'])"));

        //Add language level value drop down
        private static IWebElement AddLanguageValue => Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//select[@name='level'])"));

        //AddLanguagebutton
        private static IWebElement AddLanguagebutton => Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//input[@value='Add'])[1]"));

        //Edit Language in the language table
        private static IWebElement Editlanguage => Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//i[@class='outline write icon'])[1]"));

        //change Language level
        private static IWebElement EditLanguagelevel => Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//select[@name='level'])[1]"));
        //Click on Update language
        private static IWebElement Updatelanguage => Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//input[@value='Update'])[1]"));
        //Delete Language
        private static IWebElement Deletelanguage => Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//i[@class='remove icon'])[1]"));

        //LanguagelastRowValue
        private static IWebElement LangnameValue => Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//tbody[last()]//td[1]"));

        //LanguagelevelValue
        private static IWebElement LanglevelValue => Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//tbody[last()]//td[2]"));

        #endregion

        #region Skills elements
        //Click on skills
        private static IWebElement Skills => Driver.driver.FindElement(By.XPath("//a[@data-tab='second']"));

        //Click on Addnew button
        private static IWebElement Addnewbutton => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//div[@class='ui teal button' and text()='Add New']"));
        //Add the skill name
        private static IWebElement Skillname => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//input[@placeholder='Add Skill']"));
        //Choose skill level
        private static IWebElement Skilllevel => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//select[@name='level']"));
        //Click on Add
        private static IWebElement Skilladd => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//input[@value='Add']"));
        //Click on Edit skill button
        private static IWebElement Editskill => Driver.driver.FindElement(By.XPath("//*[@data-tab='second']//table//tbody//tr//td[3]//i[@class='outline write icon']"));
        //Edit skill name
        private static IWebElement Editskillname => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//input[@placeholder='Add Skill']"));
        private static IWebElement Updateskill => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//table//tr//td//input[@value='Update']"));

        //Delete the skill added
        private static IWebElement Deleteskill => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//table//tr//td//i[@class='remove icon']"));
        //Skill added verify

        //SkillNameValue
        private static IWebElement Skillnamevalue => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//tbody[last()]//td[1]"));

        //SkilllevelValue
        private static IWebElement Skilllevelvalue => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//tbody[last()]//td[2]"));



        #endregion

        #region Education Elements


        private static IWebElement EducationAddNew => Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[3]"));

        private static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//a[text()='Education']"));

        private static IWebElement CollegeName => Driver.driver.FindElement(By.XPath("//input[@name='instituteName']"));


        private static IWebElement CountryDropdown => Driver.driver.FindElement(By.XPath("//select[@name='country']"));


        private static IWebElement TitleDropdown => Driver.driver.FindElement(By.XPath("//select[@name='title']"));


        private static IWebElement Degree => Driver.driver.FindElement(By.XPath("//input[@name='degree']"));


        private static IWebElement GradutionYearDropDown => Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));

        private static IWebElement AddButtonEducationData => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

        private static IWebElement EducationDataCountryFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[1]"));

        private static IWebElement EducationDataUniveristyFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[2]"));


        private static IWebElement EducationDataTitleFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[3]"));

        private static IWebElement EducationDataDegreeFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[4]"));

        private static IWebElement EducationDataGradYearFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[5]"));


        private static IWebElement EducationEditiconFirst => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[6]/span[1]"));


        private static IWebElement EducationDeleteiconFirst => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[6]/span[2]"));


        private static IWebElement UpdateButtonEducationData => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));


        #endregion

        #region Certification Elements

        private static IWebElement CertificationTab => Driver.driver.FindElement(By.XPath("//a[@data-tab='fourth']"));

        private static IWebElement CertificationAddNew => Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')])[4]"));



        private static IWebElement CertificateTab => Driver.driver.FindElement(By.XPath("//a[text()='Certifications']"));


        private static IWebElement CertificateAddNew => Driver.driver.FindElement(By.XPath("(//div[text()='Add New'])[4]"));


        private static IWebElement CertificateAward => Driver.driver.FindElement(By.XPath("//input[@name='certificationName']"));


        private static IWebElement CertificateFrom => Driver.driver.FindElement(By.XPath("//input[@name='certificationFrom']"));


        private static IWebElement CertificationYear => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));


        private static IWebElement CertificationAddData => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));


        private static IWebElement CertificatelastRowValue => Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[last()]//td[1]"));



        private static IWebElement CertificateFromlastRowValue => Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[last()]//td[2]"));



        private static IWebElement CertificateYearlastRowValue => Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[last()]//td[3]"));

        private static IWebElement EditCertificateIconlastRow => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[last()]//td[4]/span[1]"));


        private static IWebElement DeleteCertificateIconlastRow => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[last()]//td[4]/span[2]"));


        private static IWebElement UpdateCertificateButtonlastRow => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));



        private static IWebElement CertificatevalueEdit => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));



        private static IWebElement CertificateFromEdit => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));



        private static IWebElement CertificateYearEdit => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));


        #endregion

        #region Searchskill elements
      
        //Click on search button
        private static IWebElement Searchlink => Driver.driver.FindElement(By.XPath("//i[@class='search link icon']"));

        //Click on selected catogery
        private static IWebElement Searchcategory => Driver.driver.FindElement(By.LinkText("Programming & Tech"));
        //Click on subcategory
        private static IWebElement Searchsub => Driver.driver.FindElement(By.XPath("(//div//a[@class='item subcategory' and contains( text(),'QA')])"));
        //select filter type
        private static IWebElement Filtertype => Driver.driver.FindElement(By.XPath("(//button[@class='ui button' and contains( text(),'Online')])"));


        #endregion

        #region Share Skill
        //Share Skill Elements 
        private static IWebElement ShareSkill => Driver.driver.FindElement(By.XPath("//*[text()='Share Skill']"));

        #endregion


        #region Description method

        public static void EditDescription()
        {

            // Click on description edit icon and navigate to Descrition field 
            Driver.TurnOnWait();
            DescriptionEditIcon.Click();
        }
        public static void Entertext()
        {
            // Add Description content 
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");

            Driver.TurnOnWait();
            DescriptionTextField.SendKeys(ExcelLibHelper.ReadData(2, "Description"));
        }
        public static void TextSave()
        {
            Descriptionsave.Click();
        }
        public static void Verifytextsaved()
        {
            Driver.TurnOnWait();
            String Actualtext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
           String Expectedtext = "Description has been saved successfully";
           Assert.AreEqual(Expectedtext, Actualtext);

        }
        #endregion

        #region Title method

        public static void Dropdownclick()
        {
            // To Navigate from home page to profile page
            Driver.TurnOnWait();
           // Driver.NavigateUrl();
            Dropdown.Click();
        }
        public  static void Enterusername()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
            Firstname.Clear();
            Firstname.SendKeys(ExcelLibHelper.ReadData(2, "First Name"));
            Driver.TurnOnWait();
            Lastname.Clear();
            Lastname.SendKeys(ExcelLibHelper.ReadData(2, "Last Name"));
            Driver.TurnOnWait();
        }
        public  static void Savename()
        {
            Save.Click();
            Driver.TurnOnWait();
        }
        public static void Verifytitle()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
           String fname= ExcelLibHelper.ReadData(2, "First Name");
           String lname= ExcelLibHelper.ReadData(2, "Last Name");
            String actualText = Driver.driver.FindElement(By.XPath("//div[@class='title' and contains(text(),'Pranathi Reddy Siram')]")).Text;
            String expectedText = fname+" "+lname;
            Assert.AreEqual(expectedText, actualText);
        }
        #endregion
     
        
        #region Available method
        public static void Availableclick()
        {
            Driver.TurnOnWait();
            Availability.Click();
        }
        public static void Availabletime()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
            SelectElement Availobj = new SelectElement(Type);
            Availobj.SelectByText(ExcelLibHelper.ReadData(2, "Availability"));
           
        }
        public static void VerifyAvailbilityadded()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
            //String Avail1 = ExcelLibHelper.ReadData(2, "Availability");
            Driver.TurnOnWait();
            String actualText = Driver.driver.FindElement(By.XPath("(//div[@class='right floated content'])[2]")).Text;
            //actualText.Contains(ExcelLibHelper.ReadData(2, "Availability"));
            //String expectedText = Avail1;
            Assert.IsTrue(actualText.Contains(ExcelLibHelper.ReadData(2, "Availability")));
  }
        #endregion
     
        
        #region Hours method
        public static void Hoursclick()
        {
            Driver.TurnOnWait();
            Hours.Click();
        }
        public  static void Hoursneed()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");

            SelectElement Hourobj = new SelectElement(Availablehours);
            Hourobj.SelectByText(ExcelLibHelper.ReadData(2, "Hours"));
        }
        public static void Verifyhoursadded()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
            Driver.TurnOnWait();
            String actualText = Driver.driver.FindElement(By.XPath("(//div[@class='right floated content'])[3]")).Text;
            // String expectedText = "Availability updated";
            Assert.IsTrue(actualText.Contains(ExcelLibHelper.ReadData(2, "Hours")));
       }

        #endregion

        #region Target method

        public static void Earnclick()
        {
            Driver.TurnOnWait();
            Earn.Click();
        }

        public static void Tgtearn()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");

        SelectElement Earnobj = new SelectElement(Targetearn);
        Earnobj.SelectByText(ExcelLibHelper.ReadData(2, "Earn Target "));
            }
        public static void Verifytargetadded()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");

            Driver.TurnOnWait();
            String Actualearn = Driver.driver.FindElement(By.XPath("(//div[@class='right floated content'])[4]")).Text;
            //String expectedText = "Availability updated";
            Assert.IsTrue(Actualearn.Contains(ExcelLibHelper.ReadData(2, "Earn Target ")));

        }


        #endregion

        #region language method
        public static void Navigatetolanguage()
        {
            Languagetab.Click();
        }
        public static void Langadd()
        { 
            // Add New language 
            Driver.TurnOnWait();
            LanguageAddNew.Click();

        }

        public static void AddNewLanguage()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Language");
            Driver.TurnOnWait();
            AddLanguage.SendKeys(ExcelLibHelper.ReadData(2, "Language"));
            SelectElement levelobj = new SelectElement(AddLanguageValue);
            levelobj.SelectByText(ExcelLibHelper.ReadData(2,"Level"));
            Driver.TurnOnWait();
            AddLanguagebutton.Click();
            Thread.Sleep(1000);
        }

        public  static void VerifyAddedLanguage()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Language");
            Thread.Sleep(1000);
           
            var ActLangname = LangnameValue.Text;
            var ActLanglevel = LanglevelValue.Text;

            Assert.AreEqual(ActLangname, ExcelLibHelper.ReadData(2, "Language"), "Langguage name is not added");

            Assert.AreEqual(ActLanglevel, ExcelLibHelper.ReadData(2, "Level"), "Lanuague level is not added");

        }

        public static void Langedit()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Language");

            Driver.TurnOnWait();
            Editlanguage.Click();
        }
        public static void Langup()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Language");

            Driver.TurnOnWait();
            SelectElement Editobj = new SelectElement(EditLanguagelevel);
            Editobj.SelectByText(ExcelLibHelper.ReadData(3, "Level"));
            Updatelanguage.Click();

        }
        public  static void VerifyEditedLanguage()
        {
           ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Language");
            
           Thread.Sleep(1000);
           
            var ActLanglevel = LanglevelValue.Text;
           
            Assert.AreEqual(ActLanglevel, ExcelLibHelper.ReadData(3, "Level"), "Lanuague level is not changed");


        }
        public  static void DeleteLanguage()
        {
            Driver.TurnOnWait();
            Deletelanguage.Click();

        }


        public static void VerifyDeleteLanguage()
        {

            try
            {
                ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Language");
                var ActLangname = LangnameValue.Text;
                var ActLanglevel = LanglevelValue.Text;

                Assert.AreNotEqual(ActLangname, ExcelLibHelper.ReadData(2, "Language"), "Langguage name is not deleted");

                Assert.AreNotEqual(ActLanglevel, ExcelLibHelper.ReadData(3, "Level"), "Lanuague level is not deleted");

            }
            catch (Exception )
            {

                Assert.True(true, "Element not found");
            }

        }
        #endregion

        #region Skills method
        public static void Navigatetoskills()
        {
            Driver.TurnOnWait();
            Skills.Click();
        }
        public static void Addclick()
        {
            Driver.TurnOnWait();
            Addnewbutton.Click();

        }
        public static void Addnewskill()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\\Mars\\AdvancedTaskTeam-master\\onboarding.specflow-master\\MarsQA-1\\SpecflowTests\\Data\\ProfileData.xlsx", "Skill");
            Driver.TurnOnWait();
            Skillname.SendKeys(ExcelLibHelper.ReadData(2, "Skill"));
            SelectElement skillobj = new SelectElement(Skilllevel);
            skillobj.SelectByText(ExcelLibHelper.ReadData(2, "Level"));
            Skilladd.Click();
         }
        public static void VerifyAddedSkill()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Skill");
            Thread.Sleep(1000);
            var ActSkillname = Skillnamevalue.Text;
            var ActSkilllevel = Skilllevelvalue.Text;
            Assert.AreEqual(ActSkillname, ExcelLibHelper.ReadData(2, "Skill"),"Skill name is not added");
            Assert.AreEqual(ActSkilllevel, ExcelLibHelper.ReadData(2, "Level"), "Skill level is not added");

        }

        public static void EditSkillrecord()
        {
            Thread.Sleep(1000);
            Editskill.Click();
        }
        public static void Skillchg()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\\Mars\\AdvancedTaskTeam-master\\onboarding.specflow-master\\MarsQA-1\\SpecflowTests\\Data\\ProfileData.xlsx", "Skill");
            Editskillname.Clear();
            Driver.TurnOnWait();
            Editskillname.SendKeys(ExcelLibHelper.ReadData(3, "Skills"));
            Updateskill.Click();
            Driver.TurnOnWait();
        }
        public static void Verifyskilledit()
        {
            ExcelLibHelper.PopulateInCollection(@"D:\\Mars\\AdvancedTaskTeam-master\\onboarding.specflow-master\\MarsQA-1\\SpecflowTests\\Data\\ProfileData.xlsx", "Skill");
            var ActSkilllevel = Skilllevelvalue.Text;
            Assert.AreEqual(ActSkilllevel, ExcelLibHelper.ReadData(3, "Level"), "Skill level is changed");

        }
        public static  void Skilldelete()
        {
            Deleteskill.Click();
        }
        public  static void Verifyskilldeleted()
        {
            try
            { 
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Skill");
                var ActSkillname = Skillnamevalue.Text;
                var ActSkilllevel = Skilllevelvalue.Text;
                Assert.AreNotEqual(ActSkillname, ExcelLibHelper.ReadData(2, "Skill"), "Skill name is not deleted");
                Assert.AreNotEqual(ActSkilllevel, ExcelLibHelper.ReadData(3, "Level"), "Skill level is not deleted");

            }

            catch (Exception )
            {

                Assert.True(true, "Element not found");
            }
           
        }
        #endregion

        #region Education Methods

        public static void NavigateToEducationTab()
        {
            //Navigate to Education Tab
            Driver.TurnOnWait();
            EducationTab.Click();

        }


        public static void AddEducation()

        {

            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Education");
            //Click on Add new button for education
            Driver.TurnOnWait();
            EducationAddNew.Click();

            //Enter Valid Education details 
            Driver.TurnOnWait();

            CollegeName.SendKeys(ExcelLibHelper.ReadData(2, "CollegeName"));

            SelectElement country = new SelectElement(CountryDropdown);
            country.SelectByText(ExcelLibHelper.ReadData(2, "CountryOfCollege"));

            SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByText(ExcelLibHelper.ReadData(2, "TitleDrop"));

            Degree.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));



            Thread.Sleep(3000);
            SelectElement Yeardrop = new SelectElement(GradutionYearDropDown);
            Yeardrop.SelectByText(ExcelLibHelper.ReadData(2, "Year"));


            Thread.Sleep(3000);
            AddButtonEducationData.Click();
            Thread.Sleep(5000);

        }



        public static void EditEducation()

        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Education");

            EducationEditiconFirst.Click();

            CollegeName.Clear();

            CollegeName.SendKeys(ExcelLibHelper.ReadData(3, "CollegeName"));

            SelectElement country = new SelectElement(CountryDropdown);
            country.SelectByText(ExcelLibHelper.ReadData(3, "CountryOfCollege"));

            SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByText(ExcelLibHelper.ReadData(3, "TitleDrop"));

            Degree.Clear();

            Degree.SendKeys(ExcelLibHelper.ReadData(3, "Degree"));



            Thread.Sleep(3000);
            SelectElement Yeardrop = new SelectElement(GradutionYearDropDown);
            Yeardrop.SelectByText(ExcelLibHelper.ReadData(3, "Year"));


            Thread.Sleep(3000);
            UpdateButtonEducationData.Click();
            Thread.Sleep(5000);

        }


        public static void DeleteEducation()

        {
            EducationDeleteiconFirst.Click();

        }


        public static void VerifyAddEducation()

        {


            var actualCountry = EducationDataCountryFirstrow.Text;
            var ExpCountry = ExcelLibHelper.ReadData(2, "CountryOfCollege");

            var actualColl = EducationDataUniveristyFirstrow.Text;
            var ExpColl = ExcelLibHelper.ReadData(2, "CollegeName");


            var actualTitle = EducationDataTitleFirstrow.Text;
            var ExpTitle = ExcelLibHelper.ReadData(2, "TitleDrop");

            var actualDegree = EducationDataDegreeFirstrow.Text;
            var ExpDegree = ExcelLibHelper.ReadData(2, "Degree");

            var actualYear = EducationDataGradYearFirstrow.Text;
            var ExpYear = ExcelLibHelper.ReadData(2, "Year");

            Assert.AreEqual(actualCountry, ExpCountry, "Country is not added");

            Assert.AreEqual(actualColl, ExpColl, "College is not added");

            Assert.AreEqual(actualTitle, ExpTitle, "Title is not added");

            Assert.AreEqual(actualDegree, ExpDegree, "Degree is not added");


            Assert.AreEqual(actualYear, ExpYear, "Year is not added");

        }


        public static void VerifyEditEducation()

        {
            var actualCountry = EducationDataCountryFirstrow.Text;
            var ExpCountry = ExcelLibHelper.ReadData(3, "CountryOfCollege");

            var actualColl = EducationDataUniveristyFirstrow.Text;
            var ExpColl = ExcelLibHelper.ReadData(3, "CollegeName");


            var actualTitle = EducationDataTitleFirstrow.Text;
            var ExpTitle = ExcelLibHelper.ReadData(3, "TitleDrop");

            var actualDegree = EducationDataDegreeFirstrow.Text;
            var ExpDegree = ExcelLibHelper.ReadData(3, "Degree");

            var actualYear = EducationDataGradYearFirstrow.Text;
            var ExpYear = ExcelLibHelper.ReadData(3, "Year");

            Assert.AreEqual(actualCountry, ExpCountry, "Country is not updated");

            Assert.AreEqual(actualColl, ExpColl, "College is not updated");

            Assert.AreEqual(actualTitle, ExpTitle, "Title is not updated");

            Assert.AreEqual(actualDegree, ExpDegree, "Degree is not updated");


            Assert.AreEqual(actualYear, ExpYear, "Year is not updated");

        }


        public static void VerifyDeleteEducation()


        {

            try
            {
                var actualCountry = EducationDataCountryFirstrow.Text;
                var ExpCountry = ExcelLibHelper.ReadData(3, "CountryOfCollege");

                var actualColl = EducationDataUniveristyFirstrow.Text;
                var ExpColl = ExcelLibHelper.ReadData(3, "CollegeName");


                var actualTitle = EducationDataTitleFirstrow.Text;
                var ExpTitle = ExcelLibHelper.ReadData(3, "TitleDrop");

                var actualDegree = EducationDataDegreeFirstrow.Text;
                var ExpDegree = ExcelLibHelper.ReadData(3, "Degree");

                var actualYear = EducationDataGradYearFirstrow.Text;
                var ExpYear = ExcelLibHelper.ReadData(3, "Year");


                Assert.AreNotEqual(actualCountry, ExpCountry, "Country is not deleted");

                Assert.AreNotEqual(actualColl, ExpColl, "College is not deleted");

                Assert.AreNotEqual(actualTitle, ExpTitle, "Title is not deleted");

                Assert.AreNotEqual(actualDegree, ExpDegree, "Degree is not deleted");


                Assert.AreNotEqual(actualYear, ExpYear, "Year is not deleted");


            }

            catch (Exception e)
            {

                Assert.True(true, "No Education Data");
            }
        }


        #endregion

        #region Certification Methods

        public static void NavigateToCertification()
        {
            CertificateTab.Click();
            Driver.TurnOnWait();
        }
        public static void AddCertification()

        {

            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Certification");

            Driver.TurnOnWait();

            CertificateAddNew.Click();
            CertificateAward.SendKeys(ExcelLibHelper.ReadData(2, "Certificate"));

            CertificateFrom.SendKeys(ExcelLibHelper.ReadData(2, "From"));

            SelectElement year = new SelectElement(CertificationYear);
            year.SelectByText(ExcelLibHelper.ReadData(2, "Year"));

            CertificationAddData.Click();

            Thread.Sleep(1000);

        }
        public static void EditCertification()

        {
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Certification");

            Driver.TurnOnWait();
            EditCertificateIconlastRow.Click();

            Thread.Sleep(1000);


            CertificatevalueEdit.Clear();

            CertificatevalueEdit.SendKeys(ExcelLibHelper.ReadData(3, "Certificate"));

            CertificateFromEdit.Clear();

            CertificateFromEdit.SendKeys(ExcelLibHelper.ReadData(3, "From"));

            SelectElement year = new SelectElement(CertificateYearEdit);
            year.SelectByText(ExcelLibHelper.ReadData(3, "Year"));

            UpdateCertificateButtonlastRow.Click();


            Thread.Sleep(1000);

        }
        public static void DeleteCertification()

        {

            Driver.TurnOnWait();
            DeleteCertificateIconlastRow.Click();
            Thread.Sleep(1000);
        }

        public static void VerifyAddCertification()

        {

            Thread.Sleep(1000);
            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Certification");

            var ActCertificate = CertificatelastRowValue.Text;
            var ActFrom = CertificateFromlastRowValue.Text;
            var Actyear = CertificateYearlastRowValue.Text;

            Assert.AreEqual(ActCertificate, ExcelLibHelper.ReadData(2, "Certificate"), "Certificate is not added");

            Assert.AreEqual(ActFrom, ExcelLibHelper.ReadData(2, "From"), "From is not added");

            Assert.AreEqual(Actyear, ExcelLibHelper.ReadData(2, "Year"), "Year is not added");

        }


        public static void VerifyEditCertification()

        {

            var ActCertificate = CertificatelastRowValue.Text;
            var ActFrom = CertificateFromlastRowValue.Text;
            var Actyear = CertificateYearlastRowValue.Text;

            Assert.AreEqual(ActCertificate, ExcelLibHelper.ReadData(3, "Certificate"), "Certificate is not added");

            Assert.AreEqual(ActFrom, ExcelLibHelper.ReadData(3, "From"), "From is not added");

            Assert.AreEqual(Actyear, ExcelLibHelper.ReadData(3, "Year"), "Year is not added");


        }

        public static void VerifyDeleteCertification()

        {

            try
            {
                var ActCertificate = CertificatelastRowValue.Text;
                var ActFrom = CertificateFromlastRowValue.Text;
                var Actyear = CertificateYearlastRowValue.Text;

                Assert.AreNotEqual(ActCertificate, ExcelLibHelper.ReadData(3, "Certificate"), "Certificate is not deleted");

                Assert.AreNotEqual(ActFrom, ExcelLibHelper.ReadData(3, "From"), "From is not deleted");

                Assert.AreNotEqual(Actyear, ExcelLibHelper.ReadData(3, "Year"), "Year is not deleted");

            }

            catch (Exception e)
            {
                Assert.True(true, "No Certificate Data exists");

            }
        }

        #endregion

        #region searchskill method 
        public static void Searchclick()
        {
            Searchlink.Click();
        }
        public static void Catsearch()
            {
          //  ExcelLibHelper.PopulateInCollection(@"D:\\Mars\\AdvancedTaskTeam-master\\onboarding.specflow-master\\MarsQA-1\\SpecflowTests\\Data\\ProfileData.xlsx", "Searchskill");
            Driver.TurnOnWait();
            Searchcategory.Click();
        }
        public static void Subcatsearch()
        {
          //  ExcelLibHelper.PopulateInCollection(@"D:\\Mars\\AdvancedTaskTeam-master\\onboarding.specflow-master\\MarsQA-1\\SpecflowTests\\Data\\ProfileData.xlsx", "Searchskill");
            Driver.TurnOnWait();
            Searchsub.Click();
        }
        public static void Filter()
        {
            //ExcelLibHelper.PopulateInCollection(@"D:\\Mars\\AdvancedTaskTeam-master\\onboarding.specflow-master\\MarsQA-1\\SpecflowTests\\Data\\ProfileData.xlsx", "Searchskill");
            Driver.TurnOnWait();
            //Filtertype.SendKeys(ExcelLibHelper.ReadData(2, "filtertype"));
            Filtertype.Click();
        }
        #endregion

        #region Service Listing navigation
        public static void NavigatetoServiceListingPage()
        {
            Driver.TurnOnWait();
            ShareSkill.Click();
            Thread.Sleep(2000);

        }

        #endregion

    }
}

