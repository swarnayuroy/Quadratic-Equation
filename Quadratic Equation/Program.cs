using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            try
            {
                c1:
                Console.WriteLine("--------SOLVING QUADRATIC EQUATION---------");
                Console.WriteLine("\t\tax\xB2 + bx + c");
                Console.Write("\nEnter coefficient of x\xB2: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter coefficient of x: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Enter constant value(c): ");
                int c = int.Parse(Console.ReadLine());

                int d = (b * b) - (4 * a * c);
                Console.WriteLine("\nDiscriminant of the equation: " + d);
                if (d >= 0)
                {
                    double root1 = ((b * (-1)) + (Math.Sqrt(d))) / (2 * a);
                    double root2 = ((b * (-1)) - (Math.Sqrt(d))) / (2 * a);
                    Console.WriteLine("\nThe roots of the equation are: {0}, {1}", root1, root2);
                }
                else
                {
                    Console.WriteLine("\nNegative discriminant indicates that either of the solutions aren't real.");
                }
                c2:
                Console.Write("\nWant to continue with next equation (Y/N)? ");
                char choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case 'Y':
                        Console.Clear();
                        goto c1;
                    case 'N':
                        System.Environment.Exit(2);
                        break;
                    case 'y':
                        Console.Clear();
                        goto c1;
                    case 'n':
                        System.Environment.Exit(2);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid choice\n");
                        goto c2;
                }
            }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.\n");
                System.Environment.Exit(2);
            }            
        }
    }
}
