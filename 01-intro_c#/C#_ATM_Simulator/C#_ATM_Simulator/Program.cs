using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ATM_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to the ATM Simulator!");
            int input;
            int balance_value = 1000;
            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1.show Balance");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Exit");
                input = int.Parse(Console.ReadLine());
                //if (input != 1 || input != 2 || input != 3 || input != 4)
                //{
                //    Console.WriteLine("Invalid option. Please try again.");
                //}

                switch(input)
                {
                    case 1:
                        Console.WriteLine($"Your balance is: {balance_value}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the deposit value:");
                        int deposit_value = int.Parse(Console.ReadLine());
                        if (deposit_value > 0)
                        {
                            balance_value += deposit_value;
                            Console.WriteLine($"Your balance is:{balance_value}");

                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                            break;
                    case 3:
                        Console.WriteLine("Enter the withdraw value:");
                        int withdraw_value = int.Parse(Console.ReadLine());
                        if (balance_value > withdraw_value && withdraw_value > 0)
                        {
                            balance_value -= withdraw_value;
                            Console.WriteLine($"Your balance is:{balance_value}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;
                    case 4:
                        Console.WriteLine("thank you for using our service");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            } while (input != 4);
        }
    }
}

