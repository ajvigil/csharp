using System;

namespace Arrays
{
  class Program
  {
      static void Main(string[] args)
      {
        //   int thisCannotBeNull = 4;
        //   thisCannotBeNull = null; //compile error

          int? thisCouldBeNull = null;
          Console.WriteLine(thisCouldBeNull);
          Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

          thisCouldBeNull = 7;
          Console.WriteLine(thisCouldBeNull);
          Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

          //when you run it shows 077
          //the first line is blank because it is outputting the null value

      }
  }
}