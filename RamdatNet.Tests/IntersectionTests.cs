using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RamdatNet.Tests
{
    [TestClass]
    public class IntersectionTests
    {
        [TestMethod]
        public void IntersectionTests_Docs()
        {
            var setT = R.Intersection(new HashSet<int> { 1, 2, 3, 4 }, new HashSet<int> { 7, 6, 5, 4, 3 }); //=> { 4, 3 }
            var listT = R.Intersection(new List<int> { 1, 2, 3, 4 }, new List<int> { 7, 6, 5, 4, 3 }); //=> { 4, 3 }
            var arrayT = R.Intersection(new int[] { 1, 2, 3, 4 }, new int[] { 7, 6, 5, 4, 3 }); //=> { 4, 3 }

            CollectionAssert.AreEqual(setT.ToArray(), new int[] { 4, 3 });
            CollectionAssert.AreEqual(listT.ToArray(), new int[] { 4, 3 });
            CollectionAssert.AreEqual(arrayT.ToArray(), new int[] { 4, 3 });
        }

        [TestMethod]
        public void IntersectionTests_Immutability()
        {
            var list1 = new HashSet<int> { 1, 2, 3, 4 };
            var list2 = new HashSet<int> { 7, 6, 5, 4, 3 };
            var setT = R.Intersection(new HashSet<int> { 1, 2, 3, 4 }, new HashSet<int> { 7, 6, 5, 4, 3 }); //=> { 4, 3 }

            CollectionAssert.AreEqual(list1.ToArray(), new int[] { 1, 2, 3, 4 });
            CollectionAssert.AreEqual(list2.ToArray(), new int[] { 7, 6, 5, 4, 3 });
            CollectionAssert.AreEqual(setT.ToArray(), new int[] { 4, 3 });
        }
    }
}