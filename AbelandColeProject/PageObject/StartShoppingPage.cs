using AbelandColeProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelandColeProject.PageObject
{
    class StartShoppingPage
    {

        public StartShoppingPage()

        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement SearchField => driver.FindElement(By.XPath("//input[@type='search']"));
        IWebElement SearchLogo => driver.FindElement(By.XPath("//input[@type='button']"));



        public void EnterBrownie(string brownie)
        {
            SearchField.Clear();
            SearchField.SendKeys(brownie);
            

        }

        public void ClickSearchLogo()
       {
            SearchLogo.Click();
        }

        


    }
}
