using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class ApTests
    {
        [TestMethod]
        public void ApTests_int_Multiply2_Add3()
        {
            var result1 = R.Ap(
                new Func<int, int>[] { R.Multiply(2), R.Add(3) },
                new int[] { 1, 2, 3 }
            ); //=> { 2, 4, 6, 4, 5, 6 }


            CollectionAssert.AreEqual(
                new int[] { 2, 4, 6, 4, 5, 6 }, result1.ToArray()
            );

        }

        [TestMethod]
        public void ApTest_String_Concat_ToUpper()
        {
            var result2 = R.Ap(
                new Func<string, string>[] {
                    R.Concat ("tasty "),
                    s => new string (s).ToUpper ()
                },
                new string[] { "pizza", "salad" }
            ); //=> { "tasty pizza", "tasty salad", "PIZZA", "SALAD" }

            CollectionAssert.AreEqual(
                new string[] { "tasty pizza", "tasty salad", "PIZZA", "SALAD" }, result2.ToArray()
            );
        }
    }
}