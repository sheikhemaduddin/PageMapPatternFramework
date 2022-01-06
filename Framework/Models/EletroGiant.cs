using System;

namespace Framework.Models
{

    public class ElectroGiant : Card
    { 
       #region  
       //Page Properties
       public override string Name { get; set; } = "Electro Giant";
       public override int cost { get; set; } = 1;
       public override string Epic { get; set; } = "Epic"; 
       public override string Type { get; set; } = "Troop";
       public override string Arena { get; set; } = "Arena 11";
       #endregion 

    }

}