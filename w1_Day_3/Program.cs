Person p1 = new Person()
{
   FirstName = "Aminjon",
   LastName = "Amirov",
   age = 22,
   Address = "Diagnost"
};
Console.WriteLine(p1.FulName());
Console.WriteLine(p1.Birthday());
Console.WriteLine();

Rectange r = new Rectange()
{
   Width = 34,
   Height = 34
};
r.GetArea();
r.GetPerimeter();
Console.WriteLine();
Console.Write("Width write :");
r.Width = Convert.ToInt32(Console.ReadLine());
Console.Write("Height write :");
r.Height = Convert.ToInt32(Console.ReadLine()); ;
r.GetArea();
r.GetPerimeter();
Console.WriteLine();

List<Student> list = new List<Student>();
Student s1 = new Student()
{
   Name = "GHaffor",
   Gradle = 3,
   Everage = new int[4] { 30, 20, 30, 10 }
};

Student s2 = new Student()
{
   Name = "Alijon",
   Gradle = 6,
   Everage = new int[4] { 10, 80, 50, 30 },
};

Student s3 = new Student()
{
   Name = "Aminjon",
   Gradle = 10,
   Everage = new int[4] { 100, 100, 100, 100 }
};

list.Add(s1);
list.Add(s2);
list.Add(s3);

foreach (var a in list)
{
   Console.WriteLine(a.Name);
   Console.WriteLine(a.Gradle);
   Console.WriteLine(a.Average());
   if (a.Average() > 85)
   {
      Console.WriteLine($"{a.Name} Рох ёфтед");
   }
   else if (a.Average() > 70)
   {
      Console.WriteLine($"{a.Name} Кушиш кунед");
   }
   else Console.WriteLine($"{a.Name} Аз нав хонед курсро ");
   Console.WriteLine();
}