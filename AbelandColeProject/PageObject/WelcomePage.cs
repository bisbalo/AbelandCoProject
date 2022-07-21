using AbelandColeProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelandColeProject.PageObject
{
    class WelcomePage
    {

        public WelcomePage()

         {
            driver = Hooks1.driver;
         }

        IWebDriver driver;

        




       public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
  
              
        
        



    }





}



