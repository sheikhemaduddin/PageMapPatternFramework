using System;

namespace Framework.Models
{

    public class GolemCard : Card
    { 
       #region  
       //Page Properties
       public override string Name { get; set; } = "Golem";
       public override int cost { get; set; } = 1;
       public override string Rarity { get; set; } = "Epic"; 
       public override string Type { get; set; } = "Troop";
       public override string Arena { get; set; } = "Arena 10";
       #endregion 
      



    }

}