Person p1 = new Person(){
Name = "GHaffor",
Age = 25,
Height = 1.90f
};
p1.FullInfo();
p1.Walk();
p1.Eat();
Console.WriteLine();

Rectange r=new Rectange(){
Width=25,
Height=25
};
r.GetArea();
r.GetPerimeter();
Console.WriteLine();

Circle circle=new Circle(){Radius=26};
circle.GetArea();
circle.GetCircumference();
Console.WriteLine();

Shape shape=new (){
Color="red",
Name="Map",
PositionX=24,
PositionY=24
};
shape.GetPosition();
shape.GetFullInfo();
Console.WriteLine();

User user=new User(){
FirstName="Azamat",
LastName="Mergov",
UserName="Afim",
Password="Killer01"
};
user.Login("Afim","Killer01");
Console.WriteLine(user.GetFullInfo());