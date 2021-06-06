// using System;
// namespace Selenium_with_C__Learning
// {
//    public abstract class AbstractClass
//     {
//         private int a;
//         private int b;
//         protected int add = 0;

//         public abstract void Add(int p, int q);
//         public abstract void Add(double p, int q);
//         public void Display()
//         {
//             Console.WriteLine("Addtions is: {0}", add);
//         }
//     }

//     public class NewChildClass : AbstractClass
//     {
//         public override void Add(int p, int q)
//         {
//             base.add = (p+q);
//         }

//         public override void Add(double p, int q)
//         {
//             base.add = (int)p+q;
//         }
//         public static void Main(string[] args)
//         {
//             NewChildClass cobject = new NewChildClass();
//             cobject.Add(10,20);
//             cobject.Display();
//             cobject.Add(.105,20);
//             cobject.Display();
//         }
//     }
// } // _10Interface.cs