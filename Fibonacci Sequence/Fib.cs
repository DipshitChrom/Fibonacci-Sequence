using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Fib : IEnumerable<FibSequence>
    {
        private List<FibSequence> fibnumbers;

        public Fib(List<FibSequence> fibList)
        {
            fibnumbers = new List<FibSequence>();

            foreach (var item in fibnumbers)
            {
                fibnumbers.Add(item);
            }
        }

        public FibEnum getEnumerator()
        {
            return new FibEnum(fibnumbers);
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        IEnumerator<FibSequence> IEnumerable<FibSequence>.GetEnumerator()
        {
            return ((IEnumerable<FibSequence>)fibnumbers).GetEnumerator();
        }
    }
}
