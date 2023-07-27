public class Person{
   public string? FirstName;
   public string? LastName;
   public int age;
   public string? Address;
   public string FulName(){
      return $"FirstName : {FirstName} and LastName : {LastName}";
   }
   public string Birthday(){
      return $"My birth year is {2023-age}.";
   }
}