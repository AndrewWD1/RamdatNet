using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Takes a list of predicates and returns a predicate that returns true for a given list of arguments if at least one of the provided predicates is satisfied by those arguments.
        /// </summary>
        /// <code>
        /// Predicate{int} checker = R.AnyPass(new Predicate{int}[] {
        ///                             x => x % 2 == 0,
        ///                             x => x > 1
        ///                          });
        /// checker(0); //-> true
        /// checker(1); //-> false
        /// </code>
        public static Predicate<T> AnyPass<T>(IEnumerable<Predicate<T>> predicateList)
            => y => predicateList.Select(p => p(y)).Aggregate(false, (a, c) => a || c);

        /// <summary>
        /// Takes a list of predicates and returns a predicate that returns true for a given argument if every one of the provided predicates is satisfied.
        /// </summary>
        /// <code>
        /// R.AllPass(new Predicate{int}[] {
        ///   x => x % 2 == 0,
        ///   x => x > 1
        /// }, 0); //-> true
        /// </code>
        public static bool AnyPass<T>(IEnumerable<Predicate<T>> predicateList, T y)
            => predicateList.Select(p => p(y)).Aggregate(false, (a, c) => a || c);
    }
}