Post p1 = new Post()
{
   Title = "Aminjon",
   Description = "helloo",
   DateTime = DateTime.Today,
};
p1.Published();
p1.Comment("hfkdjs");
p1.Comment("dsamld");
p1.Comment("djsaodk");
p1.Comment("hdjisakl");
p1.PrintComment();
p1.Like();
p1.Like();
p1.Like();
p1.Like();
Console.WriteLine($"Всего {p1.like} лайки");
Console.WriteLine();

Post p2 = new Post()
{
   Title = "GHaffor",
   DateTime = DateTime.Today
};
p2.Published();
p2.Comment("fhld;k;");
p2.Comment("ofdsa");
p2.Comment("jkjfjdho");
p2.Comment("lkwp");
p2.PrintComment();
p2.Like();
p2.Like();
Console.WriteLine($"Всего {p2.like} лайки");
Console.WriteLine();