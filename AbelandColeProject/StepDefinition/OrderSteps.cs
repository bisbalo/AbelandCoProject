using AbelandColeProject.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AbelandColeProject.StepDefinition
{
    [Binding]
    public class OrderSteps
    {
        WelcomePage welcomepage;
        StartShoppingPage startshoppingpage;
        SearchResultPage searchresultpage;
        OrderPage orderPage;
        public OrderSteps()
        {
            welcomepage = new WelcomePage();
            startshoppingpage = new StartShoppingPage();
            searchresultpage = new SearchResultPage();
            orderPage = new OrderPage();
        }





        [Given(@"I navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            welcomepage.NavigateToWebsite(url);
        }


        
        
        [Given(@"in the search field i enter ""(.*)""")]
        public void GivenInTheSearchFieldIEnter(string brownie)
        {
            startshoppingpage.EnterBrownie(brownie);
        }
        
        [Given(@"i click on the search logo")]
        public void GivenIClickOnTheSearchLogo()
        {
            Thread.Sleep(2000);
            startshoppingpage.ClickSearchLogo();
        }
                
        [Given(@"i click on saltedimage button")]
        public void GivenIClickOnSaltedimageButton()
        {
            Thread.Sleep(2000);
            searchresultpage.ClickImageSaltedBrownie();
        }
        [Given(@"i click on Add salted button")]
        public void GivenIClickOnAddSaltedButton()
        {
            Thread.Sleep(4000);
            orderPage.ClickAddSaltedButton();
        }
       
        

        [Given(@"i enter popcorn in the search field i enter""(.*)""")]
        public void GivenIEnterPopcornInTheSearchField(string popcorn)
        {
            Thread.Sleep(2000);
            orderPage.EnterPopcornField(popcorn);


        }





        [Given(@"i click on search logo")]
        public void GivenIClickOnSearchLogo()
        {
            Thread.Sleep(2000);
            orderPage.ClickLogoSearch();
        }

        [Given(@"i click on salted popcorn image")]
        public void GivenIClickOnSaltedPopcornImage()
        {
            Thread.Sleep(2000);
            orderPage.ClickImagePopcorn();
        }

        [Given(@"i  click on Add popcornbutton")]
        public void GivenIClickOnAddPopcornbutton()
        {
            Thread.Sleep(5000);
            orderPage.ClickAddPopcornButton();
            
            
        }

       

        [Given(@"i enter hummus in the search field ""(.*)""")]
        public void GivenIEnterHummusInTheSearchField(string hummus)
        {
            Thread.Sleep(2000);
            orderPage.EnterHummusField(hummus);
        }

        
        [Given(@"i enter popcorn into the search field""(.*)""")]
        public void GivenIEnterPopcornIntoTheSearchField(string popcorn)
        {
            orderPage.EnterPopcornField(popcorn);

        }
        [Given(@"i click on Search  Huumus logo")]
        public void GivenIClickOnSearchHuumusLogo()
        {
            orderPage.ClickLogoSearchHummus();

        }

        [Given(@"i click on Add Button for Hummus Chips")]
        public void GivenIClickOnAddButtonForHummusChips()
        {
            Thread.Sleep(4000);
            orderPage.ClickAddHummusButton();
        }


        [Given(@"i  add  Two packs of  ""(.*)""")]
        public void GivenIAddTwoPacksOf(string oats)
        {
            orderPage.EnterOatsBakery(oats);
            orderPage.ClickSearchlogo();
            Thread.Sleep(4000);
            orderPage.ClickAddOats();
        }




        [Then(@"i should be able to have Twelve items in my basket")]
        public void ThenIShouldBeAbleToHaveSixItemsInMyBasket()
        {

            Thread.Sleep(3000);
            Assert.That(orderPage.IsItemsInBasketDisplayed);




        }

        [Given(@"i click on accept cookies")]
        public void GivenIClickOnAcceptCookies()
        {
            Thread.Sleep(7000);
            searchresultpage.ClickAcceptCookies();
        }





























    }

}
