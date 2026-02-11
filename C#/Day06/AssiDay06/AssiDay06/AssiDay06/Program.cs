using System;
using System.Drawing;
using System.Reflection;

namespace AssiDay06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*#region Problem1
            Point P1 = new Point(10,20);
            Console.WriteLine(P1);
            //Question:
            //cannot inherit from classes or other structs because they are value types
            //designed to be lightweight and efficient.
            #endregion*/
            /*#region Problem2
            TypeA TA = new TypeA(1, 2, 3);
            Console.WriteLine($"F: {TA.GetF()} , G: {TA.G} , H: {TA.H}");
            //Question:
            //private limits access to the same class.
            //internal allows access within the same project.
            //public allows access from anywhere, helping enforce encapsulation and code safety.
            #endregion*/
            /*#region Problem3
            Employee Emp = new Employee();
            Emp.Name = "Mohamed Nagy";
            Console.WriteLine($"Employee Name: {Emp.Name}");
            //Question:
            //Encapsulation is the practice of hiding internal data and exposing it through controlled methods or properties.
            #endregion*/
            /*#region Problem4
            Point2 P2 = new Point2(10);
            Console.WriteLine(P2);
            Point2 P3 = new Point2(10, 20);
            Console.WriteLine(P3);
            //Question:
            //Constructors in structs are used to initialize values when a struct instance is created.
            //Structs support parameterized constructor overloading, but every constructor must initialize
            //all fields since structs are value types.
            #endregion*/
            /*#region Problem5
            Point P = new Point( 5,  10) ;
            Console.WriteLine(P);
            //Question:
            //Overriding ToString() improves code readability by providing a clear and meaningful string representation of objects
            //making logging and debugging easier and cleaner.
            #endregion*/
            /*#region Problem6
            Point P1 = new Point(10, 20);
            Point P2 = P1;
            P2.X = 30; //P1.X unchanged because structs are value types and are copied by value.
            Console.WriteLine($"P1: {P1}"); //(10, 20)
            _Employee Emp = new _Employee();
            Emp.Name = "Mohamed Nagy";
            _Employee Emp2 = Emp;
            Emp2.Name = "Ahmed Ali";  //Emp.Name changed because class are ref. types 
            Console.WriteLine($"Emp Name: {Emp.Name}");
            //Question:
            //Structs are value types stored on the stack; passing them creates a copy.
            //Classes are reference types stored on the heap; passing them shares the reference
            //so changes affect the original object.
            #endregion*/

        }
    }
}
