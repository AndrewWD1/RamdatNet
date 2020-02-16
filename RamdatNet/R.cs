using System;
using System.Collections.Generic;
using System.Linq;

namespace RamdatNet
{
  public class R
  {
    /// <summary>
    /// Curried Function to add two ints.
    /// </summary>
    /// <code>
    /// R.Add(1)(2); //-> 3
    /// </code>
    public static Func<int, int> Add(int a) => b => a + b;

    /// <summary>
    /// Curried Function to add two doubles.
    /// </summary>
    /// <code>
    /// R.Add(1)(2); //-> 3
    /// </code>
    public static Func<double, double> Add(double a) => b => a + b;

    /// <summary>
    /// Curried Function to add two decimals.
    /// </summary>
    /// <code>
    /// R.Add(1)(2); //-> 3
    /// </code>
    public static Func<decimal, decimal> Add(decimal a) => b => a + b;

    /// <summary>
    /// Add two ints.
    /// </summary>
    /// <code>
    /// R.Add(1)(2); //-> 3
    /// </code>
    public static int Add(int a, int b) => a + b;

    /// <summary>
    /// Add two doubles.
    /// </summary>
    /// <code>
    /// R.Add(1)(2); //-> 3
    /// </code>
    public static double Add(double a, double b) => a + b;

    /// <summary>
    /// Add two decimals.
    /// </summary>
    /// <code>
    /// R.Add(1)(2); //-> 3
    /// </code>
    public static decimal Add(decimal a, decimal b) => a + b;

    /// <summary>
    /// Applies a function to the value at the given index of an array, returning a new copy of the array with the element at the given index replaced with the result of the function application.
    /// </summary>
    /// <code>
    /// int[] list = { 1, 2, 3 };
    /// R.Adjust( 1, R.Add(1), list ); //-> { 1, 3, 3 } 
    /// </code>
    public static List<T> Adjust<T>(int index, Func<T, T> fn, IList<T> list)
    {
      List<T> newList = new List<T>(list);
      if (index >= list.Count) return newList;
      newList[index] = fn(newList[index]);
      return newList;
    }

    /// <summary>
    /// Curried. Returns true if all elements of the list match the predicate, false if there are any that don't.
    /// </summary>
    /// <code>
    /// int[] list = { 2, 4, 6 };
    /// R.All(x => x % 2 == 0)(list); //-> true 
    /// R.All(x => x > 3)(list); //-> false 
    /// </code>
    public static Func<IEnumerable<T>, bool> All<T>(Predicate<T> p)
      => list => list.Aggregate(true, (a, c) => a && p(c));

    /// <summary>
    /// Returns true if all elements of the list match the predicate, false if there are any that don't.
    /// </summary>
    /// <code>
    /// int[] list = { 2, 4, 6 };
    /// R.All(x => x % 2 == 0, list) //-> true 
    /// R.All(x => x > 3, list) //-> false 
    /// </code>
    public static bool All<T>(Predicate<T> p, IEnumerable<T> list)
      => list.Aggregate(true, (a, c) => a && p(c));

    /// <summary>
    /// Curried. Takes a list of predicates and returns a predicate that returns true for a given argument if every one of the provided predicates is satisfied.
    /// </summary>
    /// <code>
    /// Predicate{int} checker = R.AllPass(new Predicate{int}[] {
    ///                 x => x % 2 == 0,
    ///                 x => x > 1
    ///              });
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

    /// <summary>
    /// Returns a function that always returns the given value. Note that for non-primitives the value returned is a reference to the original value.
    /// </summary>
    /// <code>
    /// var t = R.Always("Tee");
    /// t(); //-> "Tee"
    /// </code>
    public static Func<T> Always<T>(T x) => () => x;

    /// <summary>
    /// Returns true if both arguments are true; false otherwise.
    /// </summary>
    /// <code>
    /// R.And(true, true); //=> true
    /// R.And(true, false); //=> false
    /// R.And(false, true); //=> false
    /// R.And(false, false); //=> false
    /// </code>
    public static bool And(bool a, bool b) => a && b;

    /// <summary>
    /// Curried. Returns true if at least one of the elements of the list match the predicate, false otherwise.
    /// </summary>
    /// <code>
    /// int[] list = { 2, 3, 5 };
    /// R.Any(x => x % 2 == 0)(list); //-> true 
    /// R.Any(x => x > 6)(list); //-> false 
    /// </code>
    public static Predicate<IEnumerable<T>> Any<T>(Predicate<T> p)
      => list => list.Aggregate(false, (a, c) => a || p(c));

    /// <summary>
    /// Returns true if at least one of the elements of the list match the predicate, false otherwise.
    /// </summary>
    /// <code>
    /// int[] list = { 2, 3, 5 };
    /// R.Any(x => x % 2 == 0, list); //-> true 
    /// R.Any(x => x > 6, list); //-> false 
    /// </code>
    public static bool Any<T>(Predicate<T> p, IEnumerable<T> list)
      => list.Aggregate(false, (a, c) => a || p(c));

    /// <summary>
    /// Curried. Takes a list of predicates and returns a predicate that returns true for a given list of arguments if at least one of the provided predicates is satisfied by those arguments.
    /// </summary>
    /// <code>
    /// Predicate{int} checker = R.AnyPass(new Predicate{int}[] {
    ///                 x => x % 2 == 0,
    ///                 x => x > 1
    ///              });
    /// checker(0); //-> true
    /// checker(1); //-> false
    /// </code>
    public static Predicate<T> AnyPass<T>(IEnumerable<Predicate<T>> predicateList)
      => y => predicateList.Select(p => p(y)).Aggregate((a, c) => a || c);

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
      => predicateList.Select(p => p(y)).Aggregate((a, c) => a || c);

    /// <summary>
    /// Ap applies a list of functions to a list of values.
    /// </summary>
    /// <code>
    /// R.Ap(
    ///   new Func{int, int} { R.Multiply(2), R.Add(3) }, 
    ///   new int[] { 1, 2, 3 }
    /// );  //=> { 2, 4, 6, 4, 5, 6 }
    /// R.Ap(
    ///   new Func{string, string} { R.Concat("tasty "), R.ToUpper }, 
    ///   new string[] { "pizza", "salad" }
    /// );  //=> { "tasty pizza", "tasty salad", "PIZZA", "SALAD" }
    /// </code>
    public static IEnumerable<K> Ap<T, K>(IEnumerable<Func<T, K>> fns, IEnumerable<T> list)
      => fns.Select(fn => list.Select(fn)).Aggregate((a, c) => a.Concat(c));

    /// <summary>
    /// Curried. Returns a new list, composed of n-tuples of consecutive elements. If n is greater than the length of the list, an empty list is returned.
    /// </summary>
    /// <code>
    /// R.Aperture(2)(new int[] { 1, 2, 3, 4, 5 }); 
    /// //=> { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } }
    /// R.Aperture(3)(new int[] { 1, 2, 3, 4, 5 }); 
    /// //=> { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } }
    /// R.Aperture(7)(new int[] { 1, 2, 3, 4, 5 }); 
    /// //=> {}
    /// </code>
    public static Func<IEnumerable<T>, IEnumerable<IEnumerable<T>>> Aperture<T>(int num)
      => list => Aperture(num, list);

    /// <summary>
    /// Returns a new list, composed of n-tuples of consecutive elements. If n is greater than the length of the list, an empty list is returned.
    /// </summary>
    /// <code>
    /// R.Aperture(2, new int[] { 1, 2, 3, 4, 5 }); 
    /// //=> { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } }
    /// R.Aperture(3, new int[] { 1, 2, 3, 4, 5 }); 
    /// //=> { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } }
    /// R.Aperture(7, new int[] { 1, 2, 3, 4, 5 }); 
    /// //=> {}
    /// </code>
    public static IEnumerable<IEnumerable<T>> Aperture<T>(int num, IEnumerable<T> list)
    {
      List<IEnumerable<T>> a = new List<IEnumerable<T>>();
      if (num > list.Count()) return a;

      int i = 0;
      while (i < list.Count() - num)
      {
        a.Add(list.Skip(i).Take(num));
        i += 1;
      }
      return a;
    }

    /// <summary>
    /// Curried. Returns a new list containing the contents of the given list, followed by the given element.
    /// </summary>
    /// <code>
    /// R.Append("tests")( new string[] { "write", "more" }); 
    /// //=> { "write", "more", "tests" }
    /// </code>
    public static Func<IEnumerable<T>, IEnumerable<T>> Append<T>(T t)
      => list => Append(t, list);

    /// <summary>
    /// Returns a new list containing the contents of the given list, followed by the given element.
    /// </summary>
    /// <code>
    /// R.Append("tests", new string[] { "write", "more" }); 
    /// //=> { "write", "more", "tests" }
    /// </code>
    public static IEnumerable<T> Append<T>(T t, IEnumerable<T> list)
    {
      List<T> newList = new List<T>(list);
      newList.Add(t);
      return newList;
    }

    /// <summary>
    /// Takes a value and applies a function to it.
    /// </summary>
    /// <code>
    /// var t42 = R.ApplyTo(42);
    /// t42(R.Add(1)); //-> 43
    /// </code>
    public static Func<Func<T, K>, K> ApplyTo<T, K>(T t)
      => fn => fn(t);

    /// <summary>
    /// Chain maps a function over a list and concatenates the results. chain is also known as flatMap in some libraries.
    /// </summary>
    /// <code>
    /// Func{int, IEnumerable{int}} duplicate 
    ///   = n => new int[] { n, n };
    /// R.Chain(duplicate, new int[] { 1, 2, 3 }); 
    /// //-> { 1, 1, 2, 2, 3, 3 }
    /// </code>
    public static IEnumerable<K> Chain<T, K>(Func<T, IEnumerable<K>> fn, IEnumerable<T> list)
    {
      IList<IEnumerable<K>> a = new List<IEnumerable<K>>();
      foreach (var i in list) a.Add(fn(i));
      return Flatten(a);
    }

    /// <summary>
    /// Curried. Restricts a number to be within a range.
    /// </summary>
    /// <code>
    /// R.Clamp(1, 10)( -5) // => 1
    /// R.Clamp(1, 10)( 15) // => 10
    /// R.Clamp(1, 10)( 4)  // => 4
    /// </code>
    public static Func<int, int> Clamp(int a, int b)
      => c =>
        {
          if (c >= a && c <= b) return c;
          else if (c < a) return a;
          return b;
        };

    /// <summary>
    /// Performs right-to-left function composition. The last argument may have any arity; the remaining arguments must be unary.
    /// </summary>
    /// <code>
    /// Func{int, int} composed 
    ///   = R.Compose(new Func{int, int}[] {
    ///       x => x + 1,
    ///       x => x % 7
    ///     })
    /// composed(8) //-> 2
    /// composed(6) //-> 0
    /// </code>
    public static Func<T, T> Compose<T>(IEnumerable<Func<T, T>> Fns)
      => x => Fns.Reverse().Aggregate(x, (a, c) => c(a));

    /// <summary>
    /// Returns the result of concatenating the given lists or strings.
    /// </summary>
    /// <code>
    /// R.Concat(new string[] {"ABC", "DEF"}); // "ABCDEF"
    /// </code>
    public static string Concat(IEnumerable<string> list)
      => list.Aggregate("", (a, c) => a += c);

    /// <summary>
    /// Returns the result of concatenating the given lists or strings.
    /// </summary>
    /// <code>
    /// R.concat(new int[] { { 4, 5, 6 }, { 1, 2, 3 } }); 
    /// //=> { 4, 5, 6, 1, 2, 3 }
    /// </code>
    public static IEnumerable<T> Concat<T>(IEnumerable<IEnumerable<T>> list)
      => list.Aggregate(new List<T>(), (a, c) => a.Concat(c).ToList());

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Z>> Curry<T1, T2, Z>(Func<T1, T2, Z> Fn)
      => t1 => t2 => Fn(t1, t2);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Z>>> Curry<T1, T2, T3, Z>(Func<T1, T2, T3, Z> Fn)
      => t1 => t2 => t3 => Fn(t1, t2, t3);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Z>>>> Curry<T1, T2, T3, T4, Z>(Func<T1, T2, T3, T4, Z> Fn)
      => t1 => t2 => t3 => t4 => Fn(t1, t2, t3, t4);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Z>>>>> Curry<T1, T2, T3, T4, T5, Z>(Func<T1, T2, T3, T4, T5, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => Fn(t1, t2, t3, t4, t5);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Z>>>>>> Curry<T1, T2, T3, T4, T5, T6, Z>(Func<T1, T2, T3, T4, T5, T6, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => Fn(t1, t2, t3, t4, t5, t6);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Z>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, Z>(Func<T1, T2, T3, T4, T5, T6, T7, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => Fn(t1, t2, t3, t4, t5, t6, t7);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Z>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => Fn(t1, t2, t3, t4, t5, t6, t7, t8);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Z>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Z>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Z>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Z>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Z>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Z>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Z>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

    /// <summary>
    /// Returns a curried version of the passed in function.
    /// </summary>
    public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, Z>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Z>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Z> Fn)
      => t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t16 => Fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

    /// <summary>
    /// Finds the set (i.e. no duplicates) of all elements in the first list not contained in the second list.
    /// </summary>
    /// <code>
    /// var set1 = new HashSet{int}(new int[] { 1, 2, 3, 4 }); 
    /// var set2 = new HashSet{int}(new int[] { 7, 6, 5, 4, 3 }); 
    /// R.Difference(set1, set2); //=> { 1, 2 }
    /// </code>
    public static HashSet<T> Difference<T>(HashSet<T> a, HashSet<T> b)
      => new HashSet<T>(a.Where(t => !b.Contains(t)));

    public static Func<HashSet<T>, HashSet<T>, HashSet<T>> DifferenceWith<T>(Func<T, T, bool> Comparer)
      => (a, b) =>
      {
        HashSet<T> z = new HashSet<T>();
        foreach (T item1 in a)
        {
          Boolean found = false;
          foreach (T item2 in b)
          {
            if (Comparer(item1, item2)) found = true;
          }
          if (!found) z.Add(item1);
        }
        return z;
      };

    public static Func<IEnumerable<T>, IEnumerable<T>> Drop<T>(int i)
      => list => list.Skip(i);

    public static Func<IEnumerable<T>, IEnumerable<T>> DropLast<T>(int i)
      => list => list.Take(list.Count() - i);

    public static Func<IEnumerable<T>, IEnumerable<T>> DropLastWhile<T>(Predicate<T> Fn)
      => list =>
      {
        var newList = list.Select(x => x).ToList();
        int i = newList.Count() - 1;
        while (Fn(newList[i]))
        {
          newList.RemoveAt(i);
          i -= 1;
        }
        return newList;
      };

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
    /// Curried Map. Takes a function that acts on the elements of an IEnumrable and return a function that applies the function to each element of the IEnumerable and returns an IEnumarable.
    /// </summary>
    public static Func<IEnumerable<T>, IEnumerable<K>> Map<T, K>(Func<T, K> fn)
      => list => list.Select(fn);

    /// <summary>
    /// Standard Map. Takes a function and an enumerable. Applies the function to each element of the enumerable, and returns the new Enumerable
    /// </summary>
    public static IEnumerable<K> Map<T, K>(Func<T, K> fn, IEnumerable<T> list)
      => list.Select(fn);

    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> list)
      => list.Aggregate(new List<T>(), (a, c) => a.Concat(c).ToList());

    /// <summary>
    /// Curried Filter.
    /// </summary>
    public static Func<IEnumerable<T>, IEnumerable<T>> Filter<T>(Func<T, bool> fn)
      => list => list.Where(fn);

    /// <summary>
    /// Standard Filter.
    /// </summary>
    public static IEnumerable<T> Filter<T>(Func<T, bool> fn, IEnumerable<T> list)
      => list.Where(fn);

    public static Func<T, T> Pipe<T>(IEnumerable<Func<T, T>> Fns)
      => x => Fns.Aggregate(x, (a, c) => c(a));

    /// <summary>
    /// Standard Reduce.
    /// </summary>
    public static K Reduce<T, K>(Func<T, K, K> fn, K seed, IEnumerable<T> list)
      => list.Aggregate<T, K>(seed, (x, y) => fn(y, x));

  }
}