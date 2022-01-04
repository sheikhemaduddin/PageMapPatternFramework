using System;

namespace Framework.Models
{

    public class Card
    { 
       #region  
       //Page Properties
       public virtual string Name { get; set; } = "Mirror";
       public virtual int cost { get; set; } = 1;
       public virtual string Rarity { get; set; } = "Epic"; 
       public virtual string Type { get; set; } = "Spell";
       public virtual string Arena { get; set; } = "Arena 12";
       #endregion 
      



    }

}