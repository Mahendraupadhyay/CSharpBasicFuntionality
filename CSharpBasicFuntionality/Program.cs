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
            /*Sample Program which uses Enum*/
            {/* If program uses a set of integer numbers, Consider replacing them with Enum, Which makes program more readable and maintanable*/
                Customer[] customers = new Customer[3];
                customers[0] = new Customer { Name = "Mary", GenderType = Gender.Female };
                customers[1] = new Customer { Name = "Mark", GenderType = Gender.Male };
                customers[2] = new Customer { Name = "Sam", GenderType = Gender.Unknown };

                foreach (Customer cust in customers)
                    Console.WriteLine("Name {0} && Ganeder {1}", cust.Name, GetGender(cust.GenderType));

                string GetGender(Gender gender)
                {
                    switch (gender)
                    {
                        case Gender.Male:
                            return "Male";
                        case Gender.Female:
                            return "Female";
                        case Gender.Unknown:
                            return "Unknown";
                        default:
                            return "Wrong Data";
                    }
                }
            }
            /*****End*****/

            /* Lamda Expression on List of object to fetch a particular item*/
            {
                List<Customer> list = new List<Customer>();
                Customer cust = new Customer(1, "A");
                list.Add(cust);
                Customer cust1 = new Customer(2, "B");
                list.Add(cust1);

                var details = list
                              .Where(p => p.Id == 1).FirstOrDefault();

                Console.WriteLine(details.Id.ToString() + details.Name);
            }
            /****End********/

            /*Array Sorting  (bubble  sorting)  **Start***/
            {
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
            }
            /****End********/

            //******************************************************
            /*Generics example*/
            {
                bool isEqual = Test<string>.IsTrue("Mahendra", "Mahendra");
                Console.Write(isEqual);

                ArrayList arr = new ArrayList
                {
                    1,
                    "A"
                };
                foreach (var a in arr)
                    Console.WriteLine(a);
                Console.ReadKey();
            }
            /****End********/
        }
    }
    class Test<T>
    {
        internal static bool IsTrue(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    class Customer
    {
        internal Customer(int id1, string name1)
        {
            Id = id1; Name = name1;
        }
        internal Customer() {}
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender GenderType { get; set; }
        public override string ToString()
        {
            return Id + "," + Name;
        }
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}
