using basic_bank_accont_simulation.Class;
using System;
using System.Globalization;

namespace basic_bank_accont_simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our bank\n");

            Console.WriteLine("Please enter your name:");

            string name = Console.ReadLine();

            Console.WriteLine("\nEnter your starting balance:");

            decimal startingBalance = Convert.ToDecimal(Console.ReadLine());

            BankAccount account = new BankAccount(startingBalance);

            Console.WriteLine($"\nAccount created! Welcome to you new bank account {name}!");

            bool isRunning = true;

            while(isRunning == true)
            {
                Console.WriteLine("\nActions: 1. Balance, 2. Deposit , 3. Withdraw , 4. Exit");

                string action = Console.ReadLine();

                decimal balance = account.GetBalance(startingBalance);

                if (action != "balance"  &&  action != "1" && 
                    action != "deposit"  &&  action != "2" && 
                    action != "withdraw" &&  action != "3" && 
                    action != "exit"     &&  action != "4")
                {
                    Console.WriteLine("\nIncorrect action! Please try again!");
                }
                else if (action == "balance" || action == "1")
                {
                    Console.WriteLine($"\nYour balance is: " +
                        $"{balance.ToString("C", CultureInfo.CurrentCulture)}");
                }
                else if (action == "deposit" || action == "2")
                {
                    Console.WriteLine("\nEnter the amount you'd like to deposit:");

                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

                    decimal newBalance = account.Deposit(depositAmount);

                    Console.WriteLine($"\nYour new balance is: " +
                        $"{newBalance.ToString("C", CultureInfo.CurrentCulture)}");
                }
                else if (action == "withdraw" || action == "3")
                {
                    Console.WriteLine("\nEnter the amount you'd like to withdraw:");

                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

                    if (withdrawAmount > balance)
                    {
                        Console.WriteLine($"\nInsufficent fund you available balance is: " +
                            $"{balance.ToString("C", CultureInfo.CurrentCulture)}");
                    } 
                    else
                    {
                        decimal newBalance = account.Withdraw(withdrawAmount);

                        Console.WriteLine($"\nYour new balance is: " +
                            $"{newBalance.ToString("C", CultureInfo.CurrentCulture)}");
                    }
                }
                else if (action == "exit"|| action == "4")
                {
                    Console.WriteLine("\nAre you sure you would like to exit your account?");

                    Console.WriteLine("\nY : N ?");

                    string isExiting = Console.ReadLine();

                    if (isExiting == "y" || isExiting == "Y")
                    {
                        isRunning = false;

                        Console.WriteLine("\nThank you for banking with us!");
                    } 
                    else if (isExiting == "n" || isExiting == "N")
                    {
                        isRunning = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
