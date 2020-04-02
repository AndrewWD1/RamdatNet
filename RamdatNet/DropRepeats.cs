using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new list without any consecutively repeating elements.
        /// </summary>
        /// <code>
        /// R.DropRepeats(new int[] { 1, 1, 1, 2, 3, 4, 4, 2, 2 });
        /// //=> { 1, 2, 3, 4, 2 }
        /// </code>
        public static IEnumerable<T> DropRepeats<T>(IList<T> list)
        where T : IComparable
        {
            List<T> newList = new List<T>();
            if (list.Count() < 1) return newList;
            newList.Add(list[0]);
            for (int i = 1; i < list.Count(); i++)
            {
                if (list[i].CompareTo(list[i - 1]) != 0) newList.Add(list[i]);
            }
            return newList;
        }

        /// <summary>
        /// Returns a new list without any consecutively repeating elements.
        /// </summary>
        /// <code>
        /// R.DropRepeats("rraammddaa"); //=> "ramda"
        /// </code>
        public static string DropRepeats(string str)
        {
            StringBuilder newString = new StringBuilder();

            if (str.Length < 1) return newString.ToString();
            newString.Append(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i].CompareTo(str[i - 1]) != 0) newString.Append(str[i]);
            }
            return newString.ToString();
        }
    }
}