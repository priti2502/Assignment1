using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ArithmeticOperation
    {
        public void arithmeticOp() {
            int a = 20, b = 10;
            Console.WriteLine($"Addition of {a} and {b} is: {a + b}");
            Console.WriteLine($"Subtraction of {a} and {b} is: {a - b}");
            Console.WriteLine($"Multiplication of {a} and {b} is: {a * b}");
            Console.WriteLine($"Division of {a} and {b} is: {a/b}");

        } 
    }
}
