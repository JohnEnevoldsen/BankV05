using System;

namespace BankV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount("John");
            BankAccount glebAccount = new BankAccount("Gleb");
            BankAccount simonAccount = new BankAccount("Simon");

            simonAccount.Deposit(1000);
            myAccount.Deposit(2000);
            Console.WriteLine($"Account balance is : {myAccount.Balance}");

            simonAccount.Deposit(1000);
            myAccount.Withdraw(1500);
            Console.WriteLine($"Account balance is : {myAccount.Balance}");
            Console.WriteLine($"The owner of this account is : {myAccount.Owner}");

            simonAccount.Deposit(1000);
            glebAccount.Deposit(9000);
            Console.WriteLine($"{glebAccount.Owner}'s Account balance is : {glebAccount.Balance}");
            Console.WriteLine($"{simonAccount.Owner}'s Account balance is : {simonAccount.Balance}");

            // The LAST line of code should be ABOVE this line
        }
    }
}