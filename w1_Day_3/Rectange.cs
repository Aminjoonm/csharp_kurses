public class Rectange
{
    public int Width;
    public int Height;
    public string? Color;
    public void GetArea()
    {
        System.Console.WriteLine($"GetArea Rectange : {Width*Height}");
    }
    public void GetPerimeter()
    {
         int s=(Width+Height)*2;
        System.Console.WriteLine($"GetPerimeter Rectange : {s}");
    }
}