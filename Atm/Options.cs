using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Atm
{
    public class Options
    {
        int balance = 1000;
        
        public void Mai()
        {
            Console.WriteLine("Hello, ");
            string prompt = "Welcome to our atm";
            string[] options = { "Withdraw", "Check your balance", "Make a charity", "Deposit", "Exit"} ;
         
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    withdraw();
                    break;
                case 1:
                    balance1();
                    break;
                case 2:
                    charity();
                    break;
                case 3:
                    deposit();
                    break;
                case 4:
                    exit();
                    break;
            }

             void withdraw()
            {
                Console.WriteLine("How much money you want to withdraw?");
                int withdraw = int.Parse(Console.ReadLine());
                if (withdraw > balance)
                {
                    Console.WriteLine($"You dont have that money");
                    Console.WriteLine("Press any key to return in main menu");
                    Console.ReadKey(true);
                    
                    Mai();
                }
                
                    balance = balance - withdraw;
                    Console.WriteLine($"You sucessful withdrawn {withdraw} dollars!");

                Console.WriteLine("Press any key to return in main menu");
                Console.ReadKey(true);
                Mai();
            }
             
             void balance1()
             {
                 Console.WriteLine($"You have {balance}$!");
                 Console.WriteLine("Press any key to return in main menu");
                 Console.ReadKey(true);
                 Mai();
             }


             void charity()
             {
                 Console.WriteLine("How many dollars you want to donate?");
                 int charity = int.Parse(Console.ReadLine());
                 if (charity > balance)
                 {
                     Console.WriteLine("You dont have that money. ");
                     Console.WriteLine("Press any key to return in main menu");
                     Console.ReadKey(true);
                     Mai();
                 }

                 balance = balance - charity;
                 Console.WriteLine("You sucessfully donated a money for charity!");
                 Console.WriteLine("Press any key to return in main menu");

                 Console.ReadKey(true);
                 Mai();
             }
             
             }

             void deposit()
             {
                 Console.WriteLine("How much money you want to deposit?");
                 int deposit1 = int.Parse(Console.ReadLine());
                 balance = balance + deposit1;
                 Console.WriteLine("You sucesfully deposited " + deposit1);
                 Console.WriteLine("Press any key to exit");
                 Console.ReadKey(true);
                 Mai();
             }

             void exit()
             {
                 
                 Console.WriteLine("Press any key to exit");
                 Console.ReadKey(true);
                 Environment.Exit(0);
             }
        }
    }
