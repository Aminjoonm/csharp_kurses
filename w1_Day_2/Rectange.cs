public class Rectange
{
   public int Width;
   public int Height;
   public string Color;
   public void GetArea()
   {
      Console.WriteLine($"GetArea Rectange : {Width * Height}");
   }
   public void GetPerimeter()
   {
      int sum = (Width + Height) * 2;
      Console.WriteLine($"GetPerimeter Rectange : {sum}");
   }
}