using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamdatNet.Tests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Text;

namespace RamdatNet.Tests
{
    [TestClass]
    public class FindLastTests
    {
        [TestMethod]
        public void FindLastTests_Docs()
        {
        }

        [TestMethod]
        public void FindLastTests_Not_In_List()
        {
            HasB[] list = { new HasB(1), new HasB(2) };
            var result = R.FindLast((HasB x) => x.B == 3)(list);

            Assert.IsNull(result);

            int[] listOfInts = { 1, 2, 3 };
            Action exceptionThrower = () =>
            {
                var a = R.FindLast((int x) => x == -1)(listOfInts);
                Console.WriteLine(a);
            };

            Assert.ThrowsException<Exception>(exceptionThrower);
        }
    }
}