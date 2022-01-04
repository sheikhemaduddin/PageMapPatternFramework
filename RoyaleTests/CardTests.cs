using System;
using System.IO;
using Framework.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Royale.Pages;

namespace RoyaleTests
{
    public class CardTests
    {
        IWebDriver driver;
        [SetUp]
        public void BeforeEach()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));        
            driver.Url = "https://statsroyale.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEach()
        {
           driver.Quit();
        }

        [Test]
        public void Golem_Card_Validation()
        {
            //goto stats Royale
            var cardsPage = new CardsPage(driver);
            var Golem = cardsPage.Goto().GetCardByName("Golem");
            Assert.That(Golem.Displayed);
             
        }

        [Test]
        public void IceSpiritCardDetails_Validation_TC1()
        {
            new CardsPage(driver).Goto().GetCardByName("Ice Spirit").Click();
            var cardDetails = new CardDetailsPage(driver);

            var (category, arena) = cardDetails.GetCardCategory();
            var cardName = cardDetails.Map.CardName.Text;
            var cardRarity = cardDetails.Map.CardRarity.Text;

            Assert.AreEqual("Ice Spirit", cardName);
            Assert.AreEqual("Troop", category);
            Assert.AreEqual("Arena &", arena);
            Assert.AreEqual("Common", cardRarity);

            //Navigate to Cards Page
            // driver.FindElement(By.CssSelector("a[href*= '/cards']")).Click();
            // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            // js.ExecuteScript("window.scrollBy(0,600)");

            //Navigate to Ice Spirit
            // driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']")).Click();
            // var IceSpiritWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
            //             .Until(drv => drv.FindElement(By.CssSelector("[class*='cardName']")));
            // var CardName = driver.FindElement(By.CssSelector("[class*='cardName']")).Text;
            // var cardCategories = driver.FindElement(By.CssSelector(".card__rarity")).Text.Split(", ");
            // var cardType = cardCategories[0];
            // var cardArena = cardCategories[1];
            // var cardRarity = driver.FindElement(By.CssSelector(".card__common")).Text;

            // Assert.AreEqual("Ice Spirit", CardName);
            // Assert.AreEqual("Troop", cardType);
            // Assert.AreEqual("Arena 8", cardArena);
            // Assert.AreEqual("Common", cardRarity);
        }


         [Test]
        public void MirrorCardDetails_Validation_TC2()
        {
            new CardsPage(driver).Goto().GetCardByName("Golem").Click();
            var cardDetails = new CardDetailsPage(driver);

            // var (category, arena) = cardDetails.GetCardCategory();
            // var cardName = cardDetails.Map.CardName.Text;
            // var cardRarity = cardDetails.Map.CardRarity.Text;

            var Card = cardDetails.GetBaseCard();
            var Golem = new GolemCard();

            Assert.AreEqual(Golem.Name, Card.Name);
            Assert.AreEqual(Golem.Type, Card.Type);
            Assert.AreEqual(Golem.Arena, Card.Arena);
            Assert.AreEqual(Golem.Rarity, Card.Rarity);

       }
}
}