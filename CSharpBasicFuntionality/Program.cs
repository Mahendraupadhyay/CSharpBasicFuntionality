using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasicFuntionality
{
    public delegate void delegateMethod1(string str);
    class Program
    {
        static void Main()
        {
            /*delegate usages*/
            List<Employee> emp = new List<Employee>()
            {
                new Employee{Id=1,Name="mahendra", Experience=3, Salary=3000 },
                new Employee{Id=2,Name="John", Experience=4, Salary=4004 },
                new Employee{Id=3,Name="Ted",Experience=5, Salary=6000 },
                new Employee{Id=4,Name="Paul",Experience=7, Salary=7000 },
            };

            isPromotableDelegate del = new isPromotableDelegate(IsPromoteLogic);
            Employee.EmployeePromoted(emp,del);
            // Employee.EmployeePromoted(emp,employee=>employee.Experience>=5); with the help of lamda expression
            Console.ReadKey();
            /*delegate usages End*/
            {
                Console.WriteLine("Old code begin");
                /*Print ocurance of number from 0 to 9 in  given number*/
                string s = Console.ReadLine();
                for (int i = 0; i <= 9; i++)
                {//77150
                    int count = 0;
                    char[] chh = s.ToCharArray();
                    foreach (char ch in chh)
                    {
                        if (i == (int)Char.GetNumericValue(ch))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(i + " " + count);
                }/*End*/

                Program pqwqwqw = new Program();
                pqwqwqw.IsStringPalindrome("woow");
                Console.ReadKey();
                /*Converting String Cases (From Lower to upper and upper to lower*/
                {
                    Console.WriteLine("Enter a string to convert");
                    string str = Console.ReadLine();
                    char[] ch = str.ToCharArray();
                    string newStr = string.Empty;
                    for (int i = 0; i < ch.Length; i++)
                    {
                        newStr += char.IsLower(ch[i]) ? Convert.ToString(ch[i]).ToUpper() : Convert.ToString(ch[i]).ToLower();
                    }

                    Console.WriteLine("Converted string is {0}", newStr);
                    Console.ReadKey();
                    /*End*/
                }

                bool isFlag = true;
                do
                {
                    Console.WriteLine("Enter number of string to be process");
                    int stringNumber = Convert.ToInt16(Console.ReadLine());
                    string[] strArray = new string[stringNumber];
                    int count = 0;
                    for (int i = 0; i < stringNumber; i++)
                    {
                        Console.WriteLine("Enter {0}st/nd string", i + 1);
                        strArray[i] = Console.ReadLine();
                        count += strArray[i].Length;
                    }
                    for (int i = 0; i < strArray.Length - 1; i++)
                    {
                        int temp = i;
                        char[] ch1 = strArray[i].ToCharArray();
                        char[] ch2 = strArray[i + 1].ToCharArray();
                        for (int j = 1; j < ch1.Length; j++)
                        {
                            if (ch1[j] == ch2[i])
                            {
                                count--;
                                i++;
                            }
                        }
                        i = temp;
                    }
                    Console.WriteLine("Total Number of distinct character is {0}", count);
                    Console.ReadKey();
                    Console.WriteLine("Try Again Y/N?");
                    char c = Convert.ToChar(Console.ReadLine());
                    if (c == 'N')
                        isFlag = false;
                } while (isFlag);

                Customer c1 = new Customer();
                c1.Method1();
                string aaaaa = "A", bbbbb = "B";
                c1.Method1(aaaaa, bbbbb);

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
        }
       static bool IsPromoteLogic(Employee emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }

        void IsStringPalindrome(string word)
        {
            string str = word.Substring(0, word.Length / 2);
            char[] chr = word.ToCharArray();

            Array.Reverse(chr);
            string str1 = chr.ToString().Substring(0, chr.Length / 2);
            if (str.Equals(str1))
                Console.WriteLine("Palindrome");
        }
    }
    delegate bool isPromotableDelegate(Employee emp);
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }

        public static void EmployeePromoted(List<Employee> employeeList, isPromotableDelegate isPromotable)
        {
            foreach(Employee emp in employeeList)
            {
                if (isPromotable(emp))
                    Console.WriteLine("Promoted employee is {0}", emp.Name);
            }
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
        internal void Method1(params string[] a)
        {

        }
        internal Customer(int id1, string name1)
        {
            Id = id1; Name = name1;
        }
        internal Customer() { }
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
