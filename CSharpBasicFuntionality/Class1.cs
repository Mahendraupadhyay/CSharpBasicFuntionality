using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicFuntionality
{
    /*Abstract class Usages*/
    abstract class Car : IVehicle
    {
        public void checkDriverStatus()
        {
            Console.WriteLine("Driver Status Checked");
        }
        public void ImplementGPS()
        {
            Console.WriteLine("Default Car GPS");
        }
        internal abstract int Indicator();
        public Car() { }
    }
    class Audi : Car
    {
        internal void M1(int i)
        {
            Console.WriteLine("Concreat par");
        }
        internal void M1(int k, int? i = 12)
        {
            Console.WriteLine("Optional Para");
        }
        internal override int Indicator()
        {
            Console.WriteLine("This is Audi Indicator");
            return 0;
        }
        public Audi() { }
    }
    class BMW : Car
    {
        internal override int Indicator()
        {
            Console.WriteLine("This is BMW Indicator");
            return 1;
        }
    }
    abstract class Bike : IVehicle
    {
        public virtual void ImplementGPS()
        {
            Console.WriteLine("Dafault GPS Implementation");
        }
        internal abstract void Indicator();
        internal void SomeFunction()
        {
            Console.WriteLine("Some Method");
        }
    }
    class Bajaj : Bike
    {
        public override void ImplementGPS()
        {
            Console.WriteLine("Bajaj GPS Implementation");
        }
        internal override void Indicator()
        {
            Console.WriteLine("Bajaj Indicator");
        }
    }
    class Hero : Bike
    {
        internal override void Indicator()
        {
            Console.WriteLine("Hero Indicator");
        }
    }
    interface IVehicle
    {
        void ImplementGPS();
    }

    /*Polymorphism Usages*/
    class PolyMorphism
    {
        public void Method1(int id)
        {
            Console.WriteLine("Individusl Id " + id);
        }
        public void Method1(int[] Arrid)
        {
            foreach (int id in Arrid)
            {
                Method1(id);
                //Console.WriteLine("Individusl Id " + id);
            }
        }
    }
}
