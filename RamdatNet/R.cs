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
      newList[index] = fn(newList[index]);
      return newList;
    }
    /// <summary>
    /// Curried. Returns true if all elements of the list match the predicate, false if there are any that don't.
    /// </summary>
    public static Func<IEnumerable<T>, bool> All<T>(Predicate<T> p)
      => list => list.Aggregate(true, (a, c) => a && p(c));
    /// <summary>
    /// Returns true if all elements of the list match the predicate, false if there are any that don't.
    /// </summary>
    public static bool All<T>(Predicate<T> p, IEnumerable<T> list)
      => list.Aggregate(true, (a, c) => a && p(c));
    /// <summary>
    /// Curried. Takes a list of predicates and returns a predicate that returns true for a given list of arguments if every one of the provided predicates is satisfied by those arguments.
    /// </summary>
    public static Predicate<T> AllPass<T>(IEnumerable<Predicate<T>> predicateList)
      => y => predicateList.Select(p => p(y)).Aggregate(true, (a, c) => a && c);
    /// <summary>
    /// Takes a list of predicates and returns a predicate that returns true for a given list of arguments if every one of the provided predicates is satisfied by those arguments.
    /// </summary>
    public static bool AllPass<T>(IEnumerable<Predicate<T>> predicateList, T y)
      => predicateList.Select(p => p(y)).Aggregate(true, (a, c) => a && c);

    /// <summary>
    /// Returns a function that always returns the given value. Note that for non-primitives the value returned is a reference to the original value.
    /// </summary>
    /// <para />
    /// 
    public static Func<T> Always<T>(T x) => () => x;

    public static bool And(bool a, bool b) => a && b;

    public static Predicate<IEnumerable<T>> Any<T>(Predicate<T> p)
      => list => list.Aggregate(false, (a, c) => a || p(c));
    public static bool Any<T>(Predicate<T> p, IEnumerable<T> list)
      => list.Aggregate(false, (a, c) => a || p(c));

    public static Predicate<T> AnyPass<T>(IEnumerable<Predicate<T>> predicateList)
      => y => predicateList.Select(p => p(y)).Aggregate((a, c) => a || c);
    public static bool AnyPass<T>(IEnumerable<Predicate<T>> predicateList, T y)
      => predicateList.Select(p => p(y)).Aggregate((a, c) => a || c);

    public static IEnumerable<K> Ap<T, K>(IEnumerable<Func<T, K>> fns, IEnumerable<T> list)
      => fns.Select(fn => list.Select(fn)).Aggregate((a, c) => a.Concat(c));

    public static Func<IEnumerable<T>, IEnumerable<IEnumerable<T>>> Aperture<T>(int num)
      => list => Aperture(num, list);
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

    public static Func<IEnumerable<T>, IEnumerable<T>> Append<T>(T t)
      => list => Append(t, list);
    public static IEnumerable<T> Append<T>(T t, IEnumerable<T> list)
    {
      List<T> newList = new List<T>(list);
      newList.Add(t);
      return newList;
    }

    public static Func<Func<T, K>, K> ApplyTo<T, K>(T t)
      => fn => fn(t);

    public static IEnumerable<K> Chain<T, K>(Func<T, IEnumerable<K>> fn, IEnumerable<T> list)
    {
      IList<IEnumerable<K>> a = new List<IEnumerable<K>>();
      foreach (var i in list) a.Add(fn(i));
      return Flatten(a);
    }

    public static int Clamp(int a, int b, int c)
    {
      if (c >= a && c <= b) return c;
      else if (c < a) return a;
      return b;
    }

    public static Func<T, T> Compose<T>(IEnumerable<Func<T, T>> Fns)
      => x => Fns.Reverse().Aggregate(x, (a, c) => c(a));

    public static string Concat(IEnumerable<string> list)
      => list.Aggregate("", (a, c) => a += c);
    public static IEnumerable<T> Concat<T>(IEnumerable<IEnumerable<T>> list)
      => list.Aggregate(new List<T>(), (a, c) => a.Concat(c).ToList());

    public static Func<T, Func<K, Z>> Curry<T, K, Z>(Func<T, K, Z> Fn)
      => t => k => Fn(t, k);

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
