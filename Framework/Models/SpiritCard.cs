using System;

namespace Framework.Models
{

    public class SpiritCard : Card
    { 
       #region  
       //Page Properties
       public override string Name { get; set; } = "Spirit Card";
       public override int cost { get; set; } = 1;
       public override string Rarity { get; set; } = "Common"; 
       public override string Type { get; set; } = "Troop";
       public override string Arena { get; set; } = "Arena 8";
       #endregion 

    }

}