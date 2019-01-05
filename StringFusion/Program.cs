using System;
using System.Linq;

namespace StringFusion
{
  class Program
  {
    static void Main(string[] args)
    {
      
      string a = "Barry";
      string b = "Russell";

      string newString = FuseStrings(a, b);

      Console.WriteLine(newString);
      Console.Read();
    }

    static string FuseStrings(string a, string b)
    {
      var common = string.Concat(a.Zip(b, (first,second ) => new[] {first, second}).SelectMany(x => x));
      var shortString = Math.Min(a.Length, b.Length);
      var result = common + a.Substring(shortString) + b.Substring(shortString);

      return result;
    }
  }
}
