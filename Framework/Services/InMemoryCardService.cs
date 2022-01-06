using Framework.Models;

namespace Framework.Services 
{
    public class InMemoryCardService : ICardService
    {
        public Card GetCardByName(string cardName)
        {
            switch(cardName)
              {
                  case "Golem":
                  return new GolemCard();

                  case "Electro Giant":
                  return new ElectroGiant();    

                  case "Prince":
                  return new Prince();          

                  default: 
                    throw new System.ArgumentException("Card is not available" +cardName);

              }
        }
    }



}

