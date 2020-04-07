# RamdatNet

Recreating the popular, functional JavaScript library Ramda in C# for .Net.

Example of use:

```csharp
using System;
using System.Collections.Generic;
using RamdatNet;

namespace ExampleProject
{
  class Program
  {
    public static void Main(string[] args)
    {
      /**
       * Currying Functions
       */
      Func<int, int, int, int> AddThreeNumbers
        = (x, y, z) => x + y + z;

      var CurriedAddThreeNumbers
        = R.Curry(AddThreeNumbers);

      CurriedAddThreeNumbers(1)(2)(3);
        //-> 6
      CurriedAddThreeNumbers(1)(2);
        //-> int x => x + 3
      CurriedAddThreeNumbers(1);
        //-> int x => int y => x + y + 1


      /**
       *  Flip a methods first two parameters
       */
      int[] mergeThree(params int[] args)
      {
          return args;
      }

      mergeThree(1, 2, 3)
        //-> { 1, 2, 3 }

      var flippedMergeThree
        = R.Flip(mergeThree);

      flippedMergeThree(1, 2, 3);
        //-> { 2, 1, 3 }
    }
  }
}
```
