using System.Collections.Generic;
using Framework.Models;
using RestSharp;

namespace Framework.Services
{

  public class APICardService : ICardService
  {

        public const string CARDS_API = "https://statsroyale.com/api/cards";
        public IList<Card> GetAllCards()
        {
           var Client = new RestClient(CARDS_API);
           var request = new RestRequest 
           {
                Method = Method.Get,
                RequestFormat = DataFormat.Json

           };
        }

        public Card GetCardByName(string cardName)
        {
            throw new System.NotImplementedException();
        }

     
  }


}