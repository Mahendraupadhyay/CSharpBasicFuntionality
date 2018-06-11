using System;
using System.Collections;

namespace CSharpBasicFuntionality
{
    class Program
    {
        static void Main()
        {
            /*Generics example*/
            bool isEqual = Test<string>.isTrue("Mahendra","Mahendra");
            Console.Write(isEqual);
            
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("A");
            foreach (var a in arr)
                Console.WriteLine(a);
            Console.ReadKey();
        }
    }
  class Test<T>
    {
      internal  static bool isTrue(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
