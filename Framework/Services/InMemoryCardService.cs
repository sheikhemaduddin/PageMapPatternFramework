using Framework.Models;

namespace Framework.Services 
{
    public class InMemoryCardService : ICardService
    {
        public Card GetCardByName(string cardName)
        {
            switch(cardName)
              {
                  case "Ice Spirit":
                  return new SpiritCard();

                  case "Golem":
                  return new GolemCard();

                  default: 
                    throw new System.ArgumentException("Card is not available" +cardName);


              }
        }
    }



}

