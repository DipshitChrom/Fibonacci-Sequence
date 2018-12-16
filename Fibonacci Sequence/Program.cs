using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {

            FibSequence runfibsequence = new FibSequence(0, 1);
           
            
            List<FibSequence> fibnumberlist = new List<FibSequence>();
            fibnumberlist.Add(runfibsequence);
            fibnumberlist.Add(runfibsequence);
            fibnumberlist.Add(runfibsequence);
            fibnumberlist.Add(runfibsequence);


            foreach (FibSequence A in fibnumberlist)
            {
                A.addFibnumbers();

            }

            Console.ReadLine();
        }
    }
}
