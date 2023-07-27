public class Shape
{
   public string Color;
   public string Name;
   public int PositionX;
   public int PositionY;
   public void GetPosition()
   {
      Console.WriteLine($"PositionX : {PositionX}");
      Console.WriteLine($"PositionY : {PositionY}");
   }
   public void GetFullInfo()
   {
      Console.WriteLine($"Color     : {Color}");
      Console.WriteLine($"Name      : {Name}");
      Console.WriteLine($"PositionX : {PositionX}");
      Console.WriteLine($"PositionY : {PositionY}");
   }
}