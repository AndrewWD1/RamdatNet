using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Curried. Takes a list of predicates and returns a predicate that returns true for a given argument if every one of the provided predicates is satisfied.
        /// </summary>
        /// <code>
        /// Predicate{int} checker = R.AllPass(new Predicate{int}[] {
        ///                             x => x % 2 == 0,
        ///                             x => x > 1
        ///                         });
        /// checker(4); //-> true
        /// checker(0); //-> false
        /// </code>
        public static Predicate<T> AllPass<T>(IEnumerable<Predicate<T>> predicateList)
            => y => predicateList.Select(p => p(y)).Aggregate(true, (a, c) => a && c);

        /// <summary>
        /// Takes a list of predicates and returns a predicate that returns true for a given argument if every one of the provided predicates is satisfied.
        /// </summary>
        /// <code>
        /// R.AllPass(new Predicate{int}[] {
        ///   x => x % 2 == 0,
        ///   x => x > 1
        /// }, 4); //-> true
        /// </code>
        public static bool AllPass<T>(IEnumerable<Predicate<T>> predicateList, T y)
            => predicateList.Select(p => p(y)).Aggregate(true, (a, c) => a && c);
    }
}