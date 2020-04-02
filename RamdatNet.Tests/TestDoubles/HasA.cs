using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests.TestDoubles
{
    internal class HasA : IComparable
    {
        public int A { get; set; }

        public HasA(int a)
        {
            this.A = a;
        }

        public int CompareTo(object obj)
        {
            return -1;
        }

        public int CompareTo(HasA obj)
        {
            return this.A.CompareTo(obj.A);
        }
    }
}