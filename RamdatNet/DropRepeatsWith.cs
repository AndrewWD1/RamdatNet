using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a new list without any consecutively repeating elements. Equality is determined by applying the supplied predicate to each pair of consecutive elements. The first element in a series of equal elements will be preserved.
        /// </summary>
        /// <code>
        /// int[] l = { 1, -1, 1, 3, 4, -4, -4, -5, 5, 3, 3 };
        /// R.DropRepeatsWith{int}(
        ///     (x, y) => Math.Abs(x) == Math.Abs(y))(l);
        /// //=> { 1, 3, 4, -5, 3 }
        /// </code>
        public static Func<IList<T>, IEnumerable<T>> DropRepeatsWith<T>(Func<T, T, bool> Fn)
          => list =>
          {
              List<T> newList = new List<T>();
              if (list.Count() < 1) return newList;
              newList.Add(list[0]);
              for (int i = 1; i < list.Count(); i++)
              {
                  if (!Fn(list[i], list[i - 1])) newList.Add(list[i]);
              }
              return newList;
          };

        /// <summary>
        /// Returns a new list without any consecutively repeating elements. Equality is determined by applying the supplied predicate to each pair of consecutive elements. The first element in a series of equal elements will be preserved.
        /// </summary>
        /// <code>
        /// R.DropRepeats((x, y) => $"{x}{y}" == "rr")("rraammddaa");
        /// //=> "raammddaa"
        /// </code>
        public static Func<string, string> DropRepeatsWith(Func<char, char, bool> Fn)
            => str =>
            {
                StringBuilder newString = new StringBuilder();

                if (str.Length < 1) return newString.ToString();
                newString.Append(str[0]);
                for (int i = 1; i < str.Length; i++)
                {
                    if (!Fn(str[i], str[i - 1])) newString.Append(str[i]);
                }
                return newString.ToString();
            };
    }
}