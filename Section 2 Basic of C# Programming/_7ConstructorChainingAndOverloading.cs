using System;
namespace Selenium_with_C__Learning
{
    // class ConstructorChainingAndOverloading
    // {
    //     public ConstructorChainingAndOverloading() // Constructo 1
    //     {
    //          Console.WriteLine("Default Base Class Constructor");
    //     }
    //     public ConstructorChainingAndOverloading(int para) //Constructo 2
    //     {
    //         Console.WriteLine("Base Class Constructor {0}", para);
    //     }

    //     public ConstructorChainingAndOverloading(string para) //Constructo 3
    //     {
    //         Console.WriteLine("Base Class Constructor {0}", para);
    //     }
    //     public class ChildClass : ConstructorChainingAndOverloading
    //     {
    //        public ChildClass()
    //         {
    //              Console.WriteLine("Default Child Class Constructor");
    //         }
    //         public ChildClass(int para1) : base(para1)  /*Base is keyword its refering to base class*/
    //         {
    //             Console.WriteLine("Child Class Int Constructor: {0}", para1);
    //         }

    //         public ChildClass(string para1) : base(para1)  /*Base is keyword its refering to base class consturctors, methods and parameters*/
    //         {
    //             Console.WriteLine("Child Class Int Constructor: {0}", para1);
    //         }
    //     }

    //     public static void Main(string[] args)  
    //     {
    //        ChildClass cobj1 = new ChildClass(10);
    //        ChildClass cobj2 = new ChildClass("Hello...");
    //        ChildClass cobj3 = new ChildClass();
    //        ConstructorChainingAndOverloading bobj = new ConstructorChainingAndOverloading(10);
    //     }
    // }
    //_8MethodOverloadinAndBaseKeyword.cs
}