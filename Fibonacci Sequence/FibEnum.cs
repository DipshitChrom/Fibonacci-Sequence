using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class FibEnum : IEnumerator<FibSequence>
    {
        public List<FibSequence> fibnumbers;

        int position = -1;

        public FibEnum(List<FibSequence> list)
        {
            fibnumbers = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < fibnumbers.Count);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        FibSequence IEnumerator<FibSequence>.Current
        {
            get
            {
                return Current;
            }
        }

        public FibSequence Current
        {
            get
            {
                try
                {
                    return fibnumbers.ElementAt(position);
                }

                catch
                {
                    throw new InvalidOperationException();
                }
            }

        }

        object IEnumerator.Current => Current;
    }
}
