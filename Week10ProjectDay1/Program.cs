using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Program
    {
        static void Main(string[] args)
        {

            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }


            Console.Title = "Resource Library";
            string s = "Resource Library";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);

            StringBuilder menu = new StringBuilder();
            menu.Append("\n\tMenu: Enter a number to select the corresponding option\n\t");
            menu.Append("1.View Resources\n\t");
            menu.Append("2.Add Resource\n\t");
            menu.Append("3.Checkout Resource\n\t");
            menu.Append("4.Return Resource\n\t");
            menu.Append("5.Exit");


            Commands command = new Commands();
            Console.WriteLine(menu);
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "1")
                {
                    Console.Clear();
                    string title = ("\n\n\t\t\tView All Resources:\n\t\t\t*********************");
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(title);
                    command.ViewResources();
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;

                }
                else if (input == "2")
                {
                    Console.Clear();
                    string title = ("\n\n\t\t\tAdd a New Resource:\n\t\t\t************************");
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(title);
                    Console.WriteLine("Which type of resource would you like to add?\n1.DVD\n2.Book\n3.Magazine");
                    int NewInput = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        Console.Write("Enter then name of the resource you wish to add: ");
                        string newTitle = Console.ReadLine();
                        Console.Write("Enter the ISBN: ");
                        int newIsbn = int.Parse(Console.ReadLine());
                        if(NewInput == 1)
                        {
                            Console.WriteLine("What is the length in minutes? ");
                        }
                        else
                        {
                            Console.Write("What is the page length? ");
                        }
                        int newLenght = int.Parse(Console.ReadLine());
                        if(true)
                        {
                            command.AddResource(NewInput, newTitle, newIsbn, newLenght);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Try Again! Your input needs to be a valid number.");
                            break;
                        }   
                    }
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "3")
                {
                    Console.Clear();
                    string title = ("\n\n\t\t\tCheckout a Resource:\n\t\t\t***************************");
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(title);
                    Console.WriteLine("Which type of resource would you like to check out?\n1.DVD\n2.Book\n3.Magazine");
                    string NewInput = Console.ReadLine();
                    while (true)
                    {
                        if (NewInput == "1")
                        {
                            break;
                        }
                        else if(NewInput == "2")
                        {
                            break;
                        }
                        else if(NewInput == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Try Again! Your input needs to be a valid number.");
                            break;
                        }
                    }
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "4")
                {
                    Console.Clear();
                    string title = ("\n\n\t\t\tReturn a Resource:\n\t\t\t***************************");
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(title);
                    Console.WriteLine("Which type of resource would you like to check out?\n1.DVD\n2.Book\n3.Magazine");
                    string NewInput = Console.ReadLine();
                    while (true)
                    {
                        if (NewInput == "1")
                        {
                            break;
                        }
                        else if (NewInput == "2")
                        {
                            break;
                        }
                        else if (NewInput == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Try Again! Your input needs to be a valid number.");
                            break;
                        }
                    }
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "5")
                {
                    Commands.Exit();
                }
                else
                {
                    Console.WriteLine("Oops! You need to enter a vaild menu number!");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
