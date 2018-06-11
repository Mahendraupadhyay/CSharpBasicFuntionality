using System;
using System.Collections;

namespace CSharpBasicFuntionality
{
    class Program
    {
        static void Main()
        {
            /*Array Sorting  (bubble  sorting)*/
            int[] arrint = new int[7] { 5,3,6,234,45,33,434};
            int temp;

            for(int i=0;i<= arrint.Length;i++)
            {
                for(int j=0;j< arrint.Length-1;j++)
                {
                    if(arrint[j]> arrint[j+1])
                    {
                        temp = arrint[j + 1];
                        arrint[j + 1] = arrint[j];
                        arrint[j] = temp;
                    }
                }
            }
            foreach (int u in arrint)
                Console.WriteLine(u);



            //******************************************************
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
