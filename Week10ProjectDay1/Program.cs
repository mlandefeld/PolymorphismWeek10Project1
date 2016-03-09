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

            DVD dvd = new DVD();
            Book book = new Book();
            Magazine mag = new Magazine();

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
                    string title = ("\n\n\t\t\tView All Resources:\n\t\t\t*********************");//Only available ones?
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(title);
                    dvd.ViewTitle();
                    book.ViewTitle();
                    mag.ViewTitle();
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
                    string NewInput = Console.ReadLine();
                    while (true)
                    {
                        if (NewInput == "1")
                        {
                            dvd.CheckOut();
                            break;
                        }
                        else if (NewInput == "2")
                        {
                            book.CheckOut();
                            break;
                        }
                        else if (NewInput == "3")
                        {
                            mag.CheckOut();
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
                            dvd.AddTitle();
                            break;
                        }
                        else if(NewInput == "2")
                        {
                            book.AddTitle();
                            break;
                        }
                        else if(NewInput == "3")
                        {
                            mag.AddTitle();
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
                            dvd.CheckIn();
                            break;
                        }
                        else if (NewInput == "2")
                        {
                            book.CheckIn();
                            break;
                        }
                        else if (NewInput == "3")
                        {
                            mag.CheckIn();
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
