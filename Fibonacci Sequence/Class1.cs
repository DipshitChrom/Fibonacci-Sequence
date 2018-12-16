using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fibonacci_Sequence;
namespace Fibonacci_Sequence_CL
{
    [TestFixture]
    public class Class1
    {
        
        [Test]
        public void isAFibSequenceNumber()
        {
            FibSequence testnumber = new FibSequence(0, 1);
            List<FibSequence> fibnumberlist = new List<FibSequence>();
            fibnumberlist.Add(testnumber);
            long fibnumber = 1;

            foreach (FibSequence A in fibnumberlist)
            {
                A.addFibnumbers();
            }

            Assert.AreEqual(fibnumber, fibnumberlist);
        }
    }
}
