using Framework.Selenium;
using OpenQA.Selenium;

namespace Royale.Pages
{
    public class CardsPage : PageBase
    {

       public readonly CardsPageMap Map;
        public CardsPage()
        {
            Map = new CardsPageMap();
        }

        public CardsPage Goto()
        {
          HeaderNav.GoToCardsPage();
          return this;
        }
        public IWebElement GetCardByName(string cardName)
        {
            
            // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            // js.ExecuteScript("window.scrollBy(0,600)");
            // IWebElement Element = driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']"));
            // // Scrolling down the page till the element is found		
            // js.ExecuteScript("arguments[0].scrollIntoView();", Element);

            if(cardName.Contains(" "))
            {
                cardName.Replace(" ", "+");
            }
            return Map.Card(cardName);

        }
    }


    public class CardsPageMap
    {
        // IWebDriver _driver;

        // public CardsPageMap(IWebDriver driver)
        // {
        //     _driver = driver;

        // }
        public IWebElement Card(string name) => Driver.FindElement(By.CssSelector($"a[href*='{name}']"));

    }

}
