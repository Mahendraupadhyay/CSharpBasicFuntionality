using System;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasicFuntionality
{
    class Program
    {
        static void Main()
        {
            /* Lamda Expression on List of object to fetch a particular item*/
            List<Customer> list = new List<Customer>();
            Customer cust = new Customer(1, "A");
            list.Add(cust);
            Customer cust1 = new Customer(2, "B");
            list.Add(cust1);

            var details = list
                          .Where(p => p.Id ==1).FirstOrDefault();

             Console.WriteLine(details.Id.ToString()+details.Name);
            //****End********//

            /*Array Sorting  (bubble  sorting)  **Start***/
            int[] arrint = new int[7] { 5, 3, 6, 234, 45, 33, 434 };
            int temp;

            for (int i = 0; i <= arrint.Length; i++)
            {
                for (int j = 0; j < arrint.Length - 1; j++)
                {
                    if (arrint[j] > arrint[j + 1])
                    {
                        temp = arrint[j + 1];
                        arrint[j + 1] = arrint[j];
                        arrint[j] = temp;
                    }
                }
            }
            foreach (int u in arrint)
                Console.WriteLine(u);
            //****End********//

            //******************************************************
            /*Generics example*/
            bool isEqual = Test<string>.isTrue("Mahendra", "Mahendra");
            Console.Write(isEqual);

            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("A");
            foreach (var a in arr)
                Console.WriteLine(a);
            Console.ReadKey();
            //****End********//
        }
    }
    class Test<T>
    {
        internal static bool isTrue(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    class Customer
    {
        private int id;
        private string name;

        internal Customer(int id1, string name1)
        {
            Id = id1; Name = name1;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return Id + "," + Name;
        }
    }
}
