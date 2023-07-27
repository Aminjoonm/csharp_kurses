public class Post
{
   public string Title { get; set; }
   public string Description { get; set; }
   public DateTime DateTime { get; set; }
   public void Published()
   {
      if (Title != null && Description != null && DateTime != null)
      {
         Console.WriteLine("Published");
      }else {
         Console.WriteLine("Varning");
      }
   }
   public int like=0;
   public void  Like(){
     like++; 
   }
   List<string> list = new List<string>();
   public void Comment(string coment)
   {
      list.Add(coment);
   }
   public void PrintComment()
   {
      Console.WriteLine($"Коментария от {Title}");
      foreach (var e in list)
      {
         Console.WriteLine(e);
      }
   }
}