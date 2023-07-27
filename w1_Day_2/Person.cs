public class Person
{
   public string Name;
   public int Age;
   public float Height;

   public void FullInfo()
   {
      Console.WriteLine($"Name : {Name}  Age : {Age}  Height : {Height}");
   }
   public void Walk()
   {
      Console.WriteLine($"{Name} is walking");
   }
   public void Eat()
   {
      Console.WriteLine($"{Name} is eating");
   }
}