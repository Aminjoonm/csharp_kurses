public class Student
{
   public string? Name;
   public int Gradle;
   public int[]? Everage;

   public int Average()
   {
      int s = 0;
      foreach (var e in Everage)
      {
         s += e;
      }
      return (s / Everage.Length);
   }
}
