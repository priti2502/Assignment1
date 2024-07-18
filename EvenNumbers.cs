using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class EvenNumbers
    {
        public void displayEvenNumbers()
        {
            Console.WriteLine("using while loop");
            int i = 1;
            while(i<=10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("using Do while loop");
            int j = 11;
            do
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            while (j<=20);

            Console.WriteLine();

            Console.WriteLine("using for loop");

            for (int k=21;k<=30;k++)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
               
            } 



        }
    }
}
