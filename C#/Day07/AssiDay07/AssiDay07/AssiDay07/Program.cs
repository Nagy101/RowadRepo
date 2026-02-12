using AssiDay07.Classes;
using AssiDay07.Classes.Inheritance;
using AssiDay07.Interface;
using System;
using System.Diagnostics.Contracts;

namespace AssiDay07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*#region Problem1
            Car car1 = new Car();
            Console.WriteLine("Default constructor :)");
            Console.WriteLine(car1);
            Console.WriteLine("Constructor with 1 parameters :)");
            Car car2 = new Car(1);
            Console.WriteLine(car2);
            Console.WriteLine("Constructor with 2 parameters :)");
            Car car3 = new Car(2, "Mercedes");
            Console.WriteLine(car3);
            Console.WriteLine("Constructor with 3 parameters :)");
            Car car4 = new Car(3, "Audi", 50000);
            Console.WriteLine(car4);
            //Question:
            //In C#, the compiler automatically provides a default constructor only if no custom constructors are defined.
            //When i define any constructor, the compiler assumes full control and does`t generate the default constructor.
            //if a default constructor is needed along with custom ones, it must be explicitly defined.
            #endregion*/
            /*#region Problem2
            Calculator cal = new Calculator();
            cal.Sum(10, 20);
            Console.WriteLine("---------------------");
            cal.Sum(10, 20, 30);
            Console.WriteLine("---------------------");
            cal.Sum(2.5, 3.8);
            //Question:
            //Overloading makes code cleaner by grouping similar operations under one method name.
            #endregion*/
            /*#region Problem3
            Child child = new Child(30, 10, 20);
            Console.WriteLine(child);
            //Question:
            //Constructor chaining ensures that the base class constructor is executed before the derived class constructor.
            //It guarantees proper initialization of inherited members and promotes clean, reusable, and well - structured code in inheritance.
            #endregion*/
            /*#region Problem4
            //new
            Child child = new Child(2,3,4);
            Console.WriteLine(child.Product());
            //override
            Parent parent = new Child(5, 10,5);
            Console.WriteLine(parent.Product()); //50 wrong one when i remove comment in method in child class output =250
            //Question:
            //The new keyword hides the base class method and the method call is resolved based on the reference type.
            //The override keyword replaces the base method implementation and enables runtime polymorphism
            //where the call is resolved based on the actual object type.
            #endregion*/
            /*#region Problem5
            Parent parent = new Parent(5, 10);
            Console.WriteLine(parent);
            Console.WriteLine("----------------");
            Child child = new Child(2, 3, 4);
            Console.WriteLine(child);
            #endregion*/
            /*#region Problem6
            Rectangle rectangle = new Rectangle(10,5);
            rectangle.Draw();
            Console.WriteLine($"Area = {rectangle.Area}");
            //Question:
            //An interface cannot be instantiated because it does not contain any implementation.
            //It only defines a contract that classes must follow.
            //An instance can only be created from a class that implements the interface.
            #endregion*/
            /*#region Problem7
            IShape Shape = new Circle(5); 
            Shape.Draw();
            Shape.PrintDetails();
            //Question:
            //Default interface implementations allow adding new methods to interfaces without breaking existing implementations.
            //They improve code reuse and provide shared behavior while maintaining abstraction.
            #endregion*/
            /*#region Problem8
            IMovable movable = new Car();
            movable.Move();
            //Question:
            //Using an interface reference allows loose coupling, improves flexibility, and enables polymorphism.
            //It makes the code independent from concrete implementations and easier to extend and maintain.
            #endregion*/
            /*#region Problem9
            File file = new File();
            file.Read();
            file.Write();
            //Question:
            //The limitation of single inheritance by allowing a class to implement multiple interfaces.
            //Interfaces provide a way to achieve multiple inheritance of behavior contracts without the complexity and ambiguity of inheriting from multiple classes.
            #endregion*/
            /*#region Problem10
            _Rectangle Rec = new _Rectangle(20, 5.5);
            Rec.Draw();
            Rec.CalculateArea();
            //Question:
            //A virtual method has a default implementation and can optionally be overridden in derived classes.
            //An abstract method has no implementation in the base class and must be overridden in derived classes.
            #endregion*/
        }
    }
}
