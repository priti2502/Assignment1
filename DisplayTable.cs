
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DisplayTable
    {
        public void DisplayTableOfNumber() 
        {
            int num = 3;
            Console.WriteLine("using while loop");
            int i = 1;
            while (i <= 10)
            {
                
                    Console.WriteLine(i*num);
                
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("using Do while loop");

            int j = 1;
            do { 
                    Console.WriteLine(j*num);
                j++;
            }
            while (j <= 10);


            Console.WriteLine();
            Console.WriteLine("using for loop");
            for (int k = 1; k <= 10; k++)
            {
                    Console.WriteLine(k*num);
            }


        } 
    }
}
