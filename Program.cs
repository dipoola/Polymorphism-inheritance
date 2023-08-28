namespace Polymorphism___inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Polymorphism in C# is a fundamental object-oriented programming concept that allows 
            //     objects of different classes
            //     to be treated as objects of a common base class.

            //Types of polymorphism

            //  (1) Compile-time Polymorphism(Method Overloading):
            //Compile-time polymorphism, also known as method overloading,
            //     occurs when a class has multiple methods with the same name but different parameter lists.
            //     The compiler determines which method to call based on the arguments
            //    provided at compile time. 
            //Example : 

            //class Calculator
            //{
            //    public int Add(int a, int b)
            //    {
            //        return a + b;
            //    }

            //    public double Add(double a, double b)
            //    {
            //        return a + b;
            //    }
            //}

            //(2)   Run-time Polymorphism(Method Overriding):
            //  Run-time polymorphism, also known as method overriding, 
            //   involves the use of inheritance 
            //   and occurs when a derived class provides a specific implementation
            //   for a method that is already defined in its base class. 
            //   This allows objects of the derived class to exhibit different behaviors 
            //   while still adhering to the same method signature.

            //Chef chef = new Chef();
            // chef.name = "Test";
            // chef.meal = "amala and ewedu";
            // chef.cooking();

            //Akoka akoka = new Akoka();
            //akoka.name = "hilda";
            //akoka.meal = " rice and beans";
            //akoka.cooking();

            Shola shola = new Shola();
            shola.name = " catalona";
            shola.gender = " female";
            shola.cooking();



        }


        class Chef
        {
            public string name { get; set; }
            public string meal { get; set; }


            public virtual void cooking()
            {
                Console.WriteLine(" this is the only chef in Lagos");
            }
        }


        class Akoka : Chef
        {
            public string name { get; set; }
            public string meal { get; set; }

            public override void cooking()
            {
                Console.WriteLine(" this method inherited a block of codes");
            }
        }


        class Shola : Akoka
        {
            public string name { get; set; }
            public string gender { get; set; }
            public override void cooking()
            {
                Console.WriteLine(" this is the last method i created");
            }
        }

    }
}