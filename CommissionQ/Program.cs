using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;







namespace CommissionQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "CommissionQ";
            string verNum = "1.00.1";

            string adptBoot = "Now starting " + appName + " " + verNum;



            Console.Write(adptBoot + " . ");


            Thread.Sleep(1000);
            Console.Write(" . ");


            Thread.Sleep(1000);
            Console.Write(" . ");


            Thread.Sleep(5000);

            Console.Clear();
            string myCommand = null;
    
            

            do
            {
                Console.WriteLine("Welcome. Please enter a command.\nFor a list of commands, try typing 'help':");

                myCommand = Console.ReadLine();
                switch (myCommand)
                {
                    case "addClient":
                        {
                            addItem();
                            
                            Console.WriteLine("\nTask Complete.");

                            Console.ReadLine();
                       
                            break;

                        }
                   
                    default:
                        Console.WriteLine("Unknown Command. :(");
                        break;
                }
                Thread.Sleep(4000);
                Console.Clear();
            }
            while (myCommand != "exit");

           
        }

        static void addItem()
        {
            string addName = "";
            string correctName = "";
            bool clientName = false;
            Console.Write("Okay, Let's add a new client. ");
            do
            {
                Console.Write("What is their name?\n >");
                addName = Console.ReadLine();
                Console.Write("So their name is " + addName + "? [y/n]");
                correctName = Console.ReadLine();

                if (correctName == "y")
                {
                    Console.Write("Got it. " + addName + "'s profile has been added to the directory.");
                    clientName = true;
                }
            }
            while (clientName == false);
            
        }

        
    }






}