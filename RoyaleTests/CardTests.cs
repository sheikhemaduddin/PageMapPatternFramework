using System;
using System.IO;
using Framework.Models;
using Framework.Selenium;
using Framework.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Royale.Pages;

namespace RoyaleTests
{
    public class CardTests
    {
        [SetUp]
        public void BeforeEach()
        {
            Driver.Init();
            pages.Init();
            Driver.Goto("https://statsroyale.com/");
            Driver.Current.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEach()
        {
           Driver.Current.Quit();
        }

        [Test]
        public void Golem_Card_Validation()
        {
            //goto stats Royale
            var Golem = pages.Cards.Goto().GetCardByName("Golem");
            Assert.That(Golem.Displayed);
             
        }

        // [Test]
        // public void IceSpiritCardDetails_Validation_TC1()
        // {
        //     new CardsPage(Driver.Current).Goto().GetCardByName("Ice Spirit").Click();
        //     var cardDetails = new CardDetailsPage(Driver.Current);

        //     var (category, arena) = cardDetails.GetCardCategory();
        //     var cardName = cardDetails.Map.CardName.Text;
        //     var cardRarity = cardDetails.Map.CardRarity.Text;

        //     Assert.AreEqual("Ice Spirit", cardName);
        //     Assert.AreEqual("Troop", category);
        //     Assert.AreEqual("Arena &", arena);
        //     Assert.AreEqual("Common", cardRarity);

        //     //Navigate to Cards Page
        //     // driver.FindElement(By.CssSelector("a[href*= '/cards']")).Click();
        //     // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //     // js.ExecuteScript("window.scrollBy(0,600)");

        //     //Navigate to Ice Spirit
        //     // driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']")).Click();
        //     // var IceSpiritWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
        //     //             .Until(drv => drv.FindElement(By.CssSelector("[class*='cardName']")));
        //     // var CardName = driver.FindElement(By.CssSelector("[class*='cardName']")).Text;
        //     // var cardCategories = driver.FindElement(By.CssSelector(".card__rarity")).Text.Split(", ");
        //     // var cardType = cardCategories[0];
        //     // var cardArena = cardCategories[1];
        //     // var cardRarity = driver.FindElement(By.CssSelector(".card__common")).Text;

        //     // Assert.AreEqual("Ice Spirit", CardName);
        //     // Assert.AreEqual("Troop", cardType);
        //     // Assert.AreEqual("Arena 8", cardArena);
        //     // Assert.AreEqual("Common", cardRarity);
        // }

        
        static string[] cardNames = {"Prince", "Golem"};

         [Test, Category("cards")]
         //[TestCase("Golem")]
         [TestCaseSource("cardNames")]
         [Parallelizable(ParallelScope.Children)]
        public void CardDetails_Validation_TC2(string cardName)
        {
            pages.Cards.Goto().GetCardByName(cardName).Click();
            var CardOnPage = pages.CardDetails.GetBaseCard();
            var card = new InMemoryCardService().GetCardByName(cardName);
            Assert.AreEqual(card.Name, CardOnPage.Name);
            Assert.AreEqual(card.Type, CardOnPage.Type);
            Assert.AreEqual(card.Arena, CardOnPage.Arena);
            Assert.AreEqual(card.Rarity, CardOnPage.Rarity);

            // var (category, arena) = cardDetails.GetCardCategory();
            // var cardName = cardDetails.Map.CardName.Text;
            // var cardRarity = cardDetails.Map.CardRarity.Text;

            // var Card = cardDetails.GetBaseCard();
            // var Golem = new GolemCard();

            // var CardOnPage = cardDetails.GetBaseCard();
            // var card = new InMemoryCardService().GetCardByName("Golem");            
        }
         



}
}