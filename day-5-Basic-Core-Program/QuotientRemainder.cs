using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_Basic_Core_Program
{
    internal class QuotientNRemainder
    {

        public void Divide(int dividend, int divisor)
        {
            int quotient, remainder;
            quotient = dividend % divisor;
            remainder = dividend / divisor;

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");


        }
    
    }
}
