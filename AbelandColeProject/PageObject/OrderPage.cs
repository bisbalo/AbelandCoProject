using AbelandColeProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelandColeProject.PageObject
{
    class OrderPage
    {
        public OrderPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        // Locating the address of WebElemwnts on the Webpage.


        IWebElement AddSaltedButton => driver.FindElement(By.XPath("//input[@class='buttons cta-button']"));
        IWebElement SearchPopcornField => driver.FindElement(By.XPath("(//input[@title='Search'])[1]"));
        IWebElement LogoSearchPopcorn => driver.FindElement(By.XPath("(//input[@title='Search'])[2]"));
        IWebElement ImagePopcorn => driver.FindElement(By.XPath("//img[@class='lazy']"));
       
        IWebElement AddPopcornButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        IWebElement AddMorePopcornButton => driver.FindElement(By.XPath("(//div[@class='add-sign plus'])[1]"));
        IWebElement SearchField => driver.FindElement(By.XPath("//input[@type='search']"));
        IWebElement LogoSearch => driver.FindElement(By.XPath("(//input[@type='button'])[1]"));
        IWebElement AddHummusButton => driver.FindElement(By.XPath("//div[@class='add cta-button']"));
        IWebElement PlusHummus => driver.FindElement(By.XPath("//div[@class='add-sign plus']"));
        IWebElement AddOatsButton => driver.FindElement(By.XPath("//div[@class='add cta-button']"));
        IWebElement PlusOatsbutton => driver.FindElement(By.XPath("//div[@class='add-sign plus']"));
        
        IWebElement ItemsInBasket => driver.FindElement(By.XPath("//span[text()='12']"));
        
        
        
        //Methods to perform action on the WebElements


        public void ClickAddSaltedButton()
        {
            AddSaltedButton.Click();

        }


        public void ClickLogoSearch()
        {
            LogoSearchPopcorn.Click();
        }
        public void EnterPopcornField(string popcorn)
        {
            SearchPopcornField.Clear();
            SearchPopcornField.SendKeys(popcorn);
        }

        public void ClickImagePopcorn()
        {
            ImagePopcorn.Click();
        }
       
        public void ClickAddPopcornButton()
        {

            

            AddPopcornButton.Click();
            AddMorePopcornButton.Click();
            AddMorePopcornButton.Click();
            AddMorePopcornButton.Click();


        }


        public void EnterHummusField(string hummus)
        {
            SearchField.Clear();
            SearchField.SendKeys(hummus);

        }

        public void ClickLogoSearchHummus()
        {
            LogoSearch.Click();
        }

        public void ClickAddHummusButton()
        {
            AddHummusButton.Click();

            PlusHummus.Click();
            PlusHummus.Click();
            PlusHummus.Click();
            PlusHummus.Click();

        }

        public void EnterOatsBakery(string oats)
        {
            SearchField.Clear();
            SearchField.SendKeys(oats);

        }

        public void ClickSearchlogo()
        {
            LogoSearch.Click();
        }

        public void  ClickAddOats()
        {
            AddOatsButton.Click();
            PlusOatsbutton.Click();
        }
                
        

        public bool IsItemsInBasketDisplayed()
        {
            return ItemsInBasket.Displayed;
        }


    }
}
