public class User
{

   public string? FirstName;
   public string? LastName;
   public string? UserName;
   public string? Password;
   public bool IsLoggedOn;
   public void Login(string username, string password)
   {
      if (UserName == username && Password == password)
      {
         Console.WriteLine("Succses");
         IsLoggedOn = true;
      }
      else
      {
         Console.WriteLine("Warning");
      }
   }
   public void Logout()
   {
      IsLoggedOn = false;
   }
   public string GetFullInfo(){
       return ($"{FirstName} {LastName} - {IsLoggedOn}");
   }

}