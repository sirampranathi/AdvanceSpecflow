using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Managelisting
    {
        //Manage Service listing actions
        private static IWebElement EditSkill => Driver.driver.FindElement(By.XPath("//i[@class='outline write icon']"));
        private static IWebElement Deleteskill => Driver.driver.FindElement(By.XPath("//i[@class='remove icon']"));
        private static IWebElement Popupyes => Driver.driver.FindElement(By.XPath("//button[@class='ui icon positive right labeled button']"));

        //Click on search skill tab
        private static IWebElement Searchskill => Driver.driver.FindElement(By.XPath("//input[@placeholder='Search skills']"));
        //Click on filter
        private static IWebElement Filterclick => Driver.driver.FindElement(By.XPath("(//button[@class='ui button'])[3]"));

    public static void Skillsearch()
        {
     ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ServiceListData.xlsx", "Searchskill");
            Searchskill.SendKeys(ExcelLibHelper.ReadData(2, "Skillsearch"));
            Searchskill.SendKeys(Keys.Return);  
        }
        public static void EditserviceSkill()
        {
            EditSkill.Click();

            ServiceListing Skillobj = new ServiceListing();
            Skillobj.EditServiceListing();

        }


    }
}
