//Multiple classes can have same method names or signatures
using Framework.Models;

namespace Framework.Services
{
   public interface ICardService
   {
       Card GetCardByName(string cardName);
   }



}