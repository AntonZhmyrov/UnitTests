using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Controllers;
using UnitTests.Helpers;

namespace UnitTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** \t Users Management Program \t *****");

            var usersEvaluator = new UserEvaluator();

            for (;;)
            {
                Console.Write("Please, enter your username: ");
                var userName = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Please, enter your password: ");
                var userPassword = Console.ReadLine();

                Console.WriteLine();

                if (usersEvaluator.Exists(userName, userPassword))
                {
                    Console.WriteLine("You logged in successfully.");
                    Console.ReadKey(true);
                    Console.Clear();

                    Console.Write("Please, enter two numbers. \nX = ");
                    var x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Y = ");
                    var y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    Menu();

                    Console.Write("Please, select operation ");
                    var key = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    switch (key)
                    {
                        case 1:
                            Console.WriteLine("Result = " + MathOperations.Add(x, y));
                            break;

                        case 2:
                            Console.WriteLine("Result = " + MathOperations.Substract(x, y));
                            break;

                        case 3:
                            Console.WriteLine("Result = " + MathOperations.Multiply(x, y));
                            break;

                        case 4:
                            Console.WriteLine("Result = " + MathOperations.Divide(x, y));
                            break;
                    }

                    Console.ReadKey(true);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid username or password! Please, try again!");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
        }

        private static void Menu()
        {
            Console.WriteLine("Choose one of the following operations:");
            Console.WriteLine("   1 - '+';");
            Console.WriteLine("   2 - '-';");
            Console.WriteLine("   3 - '*';");
            Console.WriteLine("   4 - '/';");
            Console.WriteLine();
        }
    }
}
