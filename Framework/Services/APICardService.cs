using System.Collections.Generic;
using System.Linq;
using Framework.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Framework.Services
{

  public class APICardService : ICardService
  {

        public const string CARDS_API = "https://statsroyale.com/api/cards";
        public IList<Card> GetAllCards()
        {
           RestClient client = new RestClient(CARDS_API);
           var request = new RestRequest 
           {
                Method = Method.Get,
                RequestFormat = DataFormat.Json

           };
           

           RestResponse response = client.ExecuteAsync(request);
            

          if (response.StatusCode != System.Net.HttpStatusCode.OK)
          {
            throw new System.Exception("/Cards endpoint failed with" +response.StatusCode);
          }

            return JsonConvert.DeserializeObject<List<Card>>(response.Content);


        }

        public Card GetCardByName(string cardName)
        {
            var cards = GetAllCards();
            return cards.FirstOrDefault(card => card.Name == cardName);      
            
        }

     
  }


}