public class Circle
{
   const float PI = 3.14f;
   public int Radius;
   public string Color;
   public void GetArea()
   {
      Console.WriteLine($"GetArea Circle : {PI * Radius * Radius}");
   }
   public void GetCircumference()
   {
      float s = (Radius * PI) * 2f;
      Console.WriteLine($"GetCircumference Circle : {s}");
   }
}