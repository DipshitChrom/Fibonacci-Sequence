using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    public class FibSequence
    {
        private long previousnumber;
        private long currentnumber;

        public FibSequence(long previousnumber, long currentnumber)
        {
            this.previousnumber = previousnumber;
            this.currentnumber = currentnumber;
        }

        public void addFibnumbers()
        {
            
            for (int i = 0; i < 10; i++)
            {
                long result;
                result = currentnumber + previousnumber;

                previousnumber = currentnumber;
                currentnumber = result;
                Console.WriteLine(result);
            }
        }
    }
}
