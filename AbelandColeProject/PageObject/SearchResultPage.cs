using AbelandColeProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelandColeProject.PageObject
{
    class SearchResultPage
    {
        public SearchResultPage()
        {
            driver = Hooks1.driver;

        }

        IWebDriver driver;

        IWebElement ImageSaltedBrownie => driver.FindElement(By.XPath("//img[@class='lazy']"));
        IWebElement AcceptCookies => driver.FindElement(By.XPath("//button[text()='Accept']"));
        
        
        public void ClickImageSaltedBrownie()
        {
            ImageSaltedBrownie.Click();
        }

        public void ClickAcceptCookies()
        {
            AcceptCookies.Click();


            



        }

    }





}


