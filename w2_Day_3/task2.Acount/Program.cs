using task2.Acount;

Acount ac1 = new Acount(987976767, 89);
Console.WriteLine(ac1.GetNumber());
Console.WriteLine(ac1.GetBalance());
ac1.Credit(20);
Console.WriteLine(ac1.ToString());
ac1.Debit(40);
Console.WriteLine(ac1.ToString());

Acount ac2 = new Acount(99786756, 90);
ac1.TransferTo(20,ac2);
Console.WriteLine(ac1.ToString());
Console.WriteLine(ac2.ToString());