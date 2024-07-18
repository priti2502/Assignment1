using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DisplayNumberWithGap
    {
        public  void displayNum() {

            int i = 100;
            while (i >= 5)
            {
                Console.WriteLine(i); 
                i -= 3;
            }
        } 
    }
}
