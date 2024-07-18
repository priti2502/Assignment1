using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ArithmeticOpUsingChoice
    {
        public void arithmeticOperation()
        {
            int a = 20, b = 40;
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine($"Addition of {a} and {b} is: {a + b}");


                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Subtraction of {a} and {b} is: {a - b}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Multiplication of {a} and {b} is: {a * b}");
                        break;

                    }
                case 4:
                    {

                        Console.WriteLine($"Division of {a} and {b} is: {a / b}");
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Wrong choice");
                        break;
                    }
            }
        }

    }
}
