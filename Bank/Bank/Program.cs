using System;
using System.Globalization;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = null;

            Console.Write("Enter account number:");
            int accountNumber = int.Parse(Console.ReadLine());


            Console.Write("Enter account Holder:");
            string name = Console.ReadLine();


            Console.Write("Initial deposit? (y=yes/n=no)");
            char confirm = char.Parse(Console.ReadLine());


            if (confirm == 'y' || confirm == 'Y')
            {
                Console.Write("Deposit amount:");
                double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                account = new Account(accountNumber,name,amount);
            }
            else if(confirm == 'n' || confirm == 'N')
            {
                account = new Account(accountNumber, name);
            }
            else { Console.WriteLine("Value is not valid!"); }

            Console.WriteLine(account.ToString());

            Console.Write("Enter amount deposit: ");
            account.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Updated:");
            Console.WriteLine(account.ToString());

            Console.Write("Enter amount withdraw: ");
            account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Updated:");
            Console.WriteLine(account.ToString());
        }
    }
}
