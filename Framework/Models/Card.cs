using System;

namespace Framework.Models
{

    public class Card
    { 
       #region  
       //Page Properties
       public virtual string ID { get; set; }
       public virtual string Name { get; set; }
       public virtual string Icon { get; set; }
       public virtual int cost { get; set; } = 1;
       public virtual string Rarity { get; set; } 
       public virtual string Type { get; set; } 
       public virtual string Arena { get; set; } 
       #endregion 
      



    }

}