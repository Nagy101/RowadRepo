using AssiDay08.Classes;
using AssiDay08.Interfaces;
using AssiDay08.Struct;
using System;

namespace AssiDay08
{
    internal class Program
    {
        static void PrintTenShapes(IShapeSeries shapeSeries)
        {
            for (int i = 0; i < 10; i++)
            {
                shapeSeries.GetNextArea();
                Console.WriteLine(shapeSeries.CurrentShapeArea);
            }
            shapeSeries.ResetSeries();
        }
        static void Main(string[] args)
        {
            #region part01
            /*#region Problem1
                IVehicle vehicle = new Car();
                vehicle.StartEngine();
                vehicle.StopEngine();
                Console.WriteLine("---------------------");
                IVehicle vehicle2 = new Bike();
                vehicle2.StartEngine();
                vehicle2.StopEngine();
                //Question:
                //Coding against an interface instead of a concrete class makes the code more flexible and loosely coupled.
                //It allows changing or adding new implementations without modifying existing code,
                //which improves maintainability and scalability.
                #endregion*/
            /*#region Problem2
            Rectangle rectangle = new Rectangle(2.5,5);
            rectangle.Display();
            Console.WriteLine("------------------------");
            Circle circle = new Circle(3);
            circle.Display();
            //Question:
            //An abstract class should be preferred over an interface when classes share common behavior or state.
            //It is useful when there is a strong (is a) relationship and when you want to provide base functionality
            //while forcing subclasses to implement specific details.
            #endregion*/
            /*#region Problem3
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", 1500),
                new Product(2, "Smartphone", 800),
                new Product(3, "Tablet", 600)
            };
            Array.Sort(products);
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            //Question:
            //Implementing IComparable improves sorting flexibility by allowing a class to define its own comparison logic
            //enabling built-in sorting methods to sort objects consistently without extra code.
            #endregion*/
            /*#region Problem4
            Student st1 = new Student(10,"Mohamed",96.5);
            Student st2 =new Student(10, "Nagy", 92);
            //Shallow copy
            st2 = st1;
            Console.WriteLine(st1.ToString());
            Console.WriteLine(st2.ToString());
            Console.WriteLine(st1.GetHashCode());
            Console.WriteLine(st2.GetHashCode());
            //Deep copy
            Console.WriteLine("-----------------------");
            st2 = new Student(st1);
            Console.WriteLine(st1.ToString());
            Console.WriteLine(st2.ToString());
            Console.WriteLine(st1.GetHashCode());
            Console.WriteLine(st2.GetHashCode());
            //Question:
            //The primary purpose of a copy constructor in C# is to create an independent copy of an object
            //preventing shared memory references and avoiding issues caused by shallow copying.
            #endregion*/
            /*#region Problem5
            IWalkable walkable = new Robot();   
            walkable.Walk();
            //Question:
            //Explicit interface implementation resolves naming conflicts by allowing a class to implement interface methods separately
            //that each method is accessible only through its specific interface.
            #endregion*/
            /*#region Problem6
            Account account = new Account();
            account.AccountId = 12345;
            account.AccountHolder = "Mohamed Nagy";
            account.Balance = 10000;
            Console.WriteLine(account);
            //Question:
            //The key difference is that structs are value types, so encapsulated data is copied by value
            //while classes are reference types, so encapsulated data is shared through references.
            //Question2:
            //Abstraction is a design guideline that focuses on exposing only essential behavior while hiding implementation details. 
            //Encapsulation supports abstraction by hiding data and controlling access to it.
            #endregion*/
            /*#region Problem7
            ConsoleLogger consoleLogger = new ConsoleLogger(); 
            consoleLogger.log(); //"log message from the ConsoleLogger class."
            ILogger logger = new ConsoleLogger();
            logger.log(); //"log message from the ConsoleLogger class."
            //Question:
            //Default interface implementations improve backward compatibility by allowing
            //new methods to be added to interfaces without breaking existing implementations.
            #endregion*/
            /*#region Problem8
            Book book1 = new Book();
            Console.WriteLine(book1);
            Console.WriteLine("------------------------");
            Book book2 = new Book("Harry Potter");
            Console.WriteLine(book2);
            Console.WriteLine("------------------------");
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Console.WriteLine(book3);
            //Question:
            //Constructor overloading improves class usability by providing multiple ways to create objects based on available data
            //making the class more flexible and user-friendly.
            #endregion*/
            #endregion
            #region part02
            /*#region Problem1
            CircleSeries circleSeries = new CircleSeries();
            PrintTenShapes(circleSeries);
            Console.WriteLine("-----------");
            SquareSeries squareSeries = new SquareSeries();
            PrintTenShapes(squareSeries);
            #endregion*/
            /*#region Problem2
            _Shape[] shapes = new _Shape[]
        {
            new _Shape("Square", 16),
            new _Shape("Circle", 12.57),
            new _Shape("Rectangle", 20),
            new _Shape("Square", 9),
            new _Shape("Circle", 28.27)
        };

            Console.WriteLine("Before Sorting:");
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Array.Sort(shapes);

            Console.WriteLine("\nAfter Sorting by Area:");
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
            #endregion*/
            /*#region Problem3
            GeometricShape triangle = new Triangle(3, 4);
            GeometricShape rectangle = new _Rectangle(5, 6);

            Console.WriteLine("Triangle:");
            Console.WriteLine($"Area: {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {triangle.Perimeter}");

            Console.WriteLine("\nRectangle:");
            Console.WriteLine($"Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
            #endregion*/
            /*#region Problem4
            int[] nums = new int[] { 16, 12, 20, 9, 28 };

            Console.WriteLine("Before Sorting:");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            
            SortHelper.SelectionSort(nums);
            
            Console.WriteLine("\nAfter Sorting:");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            #endregion*/
            /*#region Problem5
            GeometricShape shape1 = ShapeFactory.CreateShape("triangle", 3, 4);
            GeometricShape shape2 = ShapeFactory.CreateShape("rectangle", 5, 6);

            Console.WriteLine("Shape 1: Triangle");
            Console.WriteLine($"Area: {shape1.CalculateArea()}, Perimeter: {shape1.Perimeter}");

            Console.WriteLine("\nShape 2: Rectangle");
            Console.WriteLine($"Area: {shape2.CalculateArea()}, Perimeter: {shape2.Perimeter}");
            #endregion*/
            #endregion
        }
    }
}
