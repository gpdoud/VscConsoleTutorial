Console.WriteLine("Banking");

Banking.Models.Account c1 = new();
Banking.Models.Account s1 = new();

c1.Deposit(1000);
c1.Withdraw(200);
System.Console.WriteLine(c1.Balance);

s1.Deposit(500);
s1.Withdraw(100);
System.Console.WriteLine(s1.Balance);

c1.Transfer(100, s1);
System.Console.WriteLine(c1.Balance);
System.Console.WriteLine(s1.Balance);