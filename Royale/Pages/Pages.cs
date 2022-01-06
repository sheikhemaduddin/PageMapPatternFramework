using System;
using Framework;
using Framework.Selenium;

namespace Royale.Pages
{
    public class pages 
    {
         
        [ThreadStatic]
        public static CardsPage Cards;
         
        [ThreadStatic]
        public static CardDetailsPage CardDetails;

        public static void Init()
        {
            Cards = new CardsPage(Driver.Current);
            CardDetails = new CardDetailsPage(Driver.Current);


        }

}
}
