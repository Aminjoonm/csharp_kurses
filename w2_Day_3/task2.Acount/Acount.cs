using System;
namespace task2.Acount;

public class Acount
{
   int number;
   decimal balance;
   public Acount(int number)
   {
      this.number = number;
   }
   public Acount(int number, decimal balance)
   {
      this.number = number;
      this.balance = balance;
   }
   public int GetNumber()
   {
      return number;
   }
   public decimal GetBalance()
   {
      return balance;
   }
   public string GoString()
   {
      return $"Account [ number = {number} , balance = {balance} ]";
   }
   public void Credit(decimal amount)
   {
      balance += amount;
   }
   public void Debit(decimal amount)
   {
      if (balance >= amount) balance -= amount;
      else Console.WriteLine("amount exeeded");
   }
   public void TransferTo(decimal amount,Acount sum )
   {
      if (balance >= amount)
      {
         balance -= amount;
         sum.Credit(amount);
      }
      else Console.WriteLine("Маблаг кофи нест");
   }
}
