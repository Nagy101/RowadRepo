using AssiDay09.Classes;
using AssiDay09.Enums;
using AssiDay09.Struct;
using System;
using System.Buffers.Text;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace AssiDay09
{
    internal class Program
    {
        public static T[] ReverseArray<T>(T[] array)
        {
            T[] reversed = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed;
        }
        public static void Swap<T>(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        public static T Max<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array is empty");

            T max = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
        static void Main(string[] args)
        {
            #region Part01
            /*#region Problem1
            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine($"{day} = {(int)day}");
            }
            //Question
            //Enums are used to represent a fixed set of named constants.
            //Explicitly assigning values to enum members is recommended when working with databases
            //external APIs, or stored data because it prevents unexpected value changes.
            //It also improves code clarity and avoids bugs when modifying or extending the enum.
            #endregion*/
            /*#region Problem2
            foreach(Grades grade in Enum.GetValues(typeof(Grades)))
            {
                Console.WriteLine($"{grade} = {(short)grade}");
            }
            //Question
            //When an enum uses a specific underlying type (such as short), all assigned values must fit within that type’s range.
            //If an enum member is assigned a value that exceeds the underlying type’s limits, the compiler will generate a compile-time error.
            //This prevents overflow issues and ensures type safety.
            #endregion*/
            /*#region Problem3
            Person P1 = new Person() { Name = "Mohamed", Age = 21, Department = "HR" };
            Person P2 = new Person() { Name = "Ahmed", Age = 25, Department = "IT" };
            Console.WriteLine(P1);
            Console.WriteLine(P2);
            //Question
            //The virtual keyword allows a property to be overridden in a derived class.
            //It enables polymorphism by allowing child classes to provide their own implementation of a property while still using a base class reference.
            //This makes the code more flexible and extensible.
            #endregion*/
            /*#region Problem4
            Child child = new Child();
            child.Salary = 8000;

            child.DisplaySalary();
            //Question
            //A sealed property or method cannot be overridden because the sealed keyword prevents further modification in derived classes.
            //It is used to enforce a final implementation, protect behavior from being changed,
            //and improve performance by allowing the compiler to optimize method calls.
            #endregion*/
            /*#region Problem5
            double perimeter = Utility.CalculateRectanglePerimeter(5, 3);
            Console.WriteLine($"Perimeter = {perimeter}");
            //Question
            //Static members belong to the class itself and can be accessed without creating an object
            //while object members belong to a specific instance of a class.
            //Static members share one memory location, whereas instance members have separate copies for each object.
            #endregion*/
            /*#region Problem6
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);

            ComplexNumber result = c1 * c2;

            Console.WriteLine($"Result = {result.Real} + {result.Imaginary}i");
            //Question
            //Not all operators in C# can be overloaded.
            //Only predefined operators that have clear and logical meanings are allowed.
            //Operators such as assignment (=), member access (.), and object creation (new) cannot be overloaded to preserve language consistency, readability, and safety.
            #endregion*/
            /*#region Problem7
            Console.WriteLine($"GenderInt size  = {sizeof(GenderInt)} bytes");
            Console.WriteLine($"GenderByte size = {sizeof(GenderByte)} bytes");
            //Question
            //You should consider changing the underlying type of an enum when its values are small and well-defined, especially if memory usage or performance is important.
            //Using smaller types like byte can reduce memory consumption, which is beneficial when working with large collections, databases, or network communication.
            #endregion*/
            /*region Problem8
            double celsius = 25;
            double fahrenheit = Utility.CelsiusToFahrenheit(celsius);

            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

            double f = 77;
            double c = Utility.FahrenheitToCelsius(f);

            Console.WriteLine($"{f}°F = {c}°C");
            //Question
            //A static class cannot have instance constructors because it cannot be instantiated.
            //Instance constructors are used to initialize objects, but static classes are loaded once by the runtime and contain only static members.
            //Only static constructors are allowed to initialize static data.
            #endregion*/
            /*#region Problem9
            string input = "A";   

            bool isValid = Enum.TryParse(input, out Grades grade);

            if (isValid)
            {
                Console.WriteLine($"Valid Grade: {grade} = {(int)grade}");
            }
            else
            {
                Console.WriteLine("Invalid grade input");
            }
            //Question
            //Enum.TryParse is safer and more robust than using int.Parse because it does not throw exceptions for invalid input.
            //It allows parsing enum names directly, returns a boolean result for validation, and produces cleaner code without try-catch blocks.
            //This makes it ideal for handling user input and preventing runtime errors.
            #endregion*/
            /*#region Problem10
            Employee[] employees = new Employee[]
             {
            new Employee { Id = 1, Name = "Ahmed" },
            new Employee { Id = 2, Name = "Sara" },
            new Employee { Id = 3, Name = "Omar" }
              };

            Employee searchEmp = new Employee { Id = 2 };
            int index = Helper2<Employee>.SearchArray(employees, searchEmp);

            if (index != -1)
                Console.WriteLine($"Found: {employees[index]} at index {index}");
            else
                Console.WriteLine("Employee not found");
            //Question
            //For classes, == compares references, while overriding Equals allows content - based comparison.
            //For structs, == compares field - by - field by default, but can be overloaded if needed.
            //Question2
            //Makes custom classes display readable information in console, logs, or debugging.
            //Without it, printing an object shows only the class name.
            #endregion*/
            /*#region Problem11
            int maxInt = Helper.Max(10, 20);
            Console.WriteLine($"Max int: {maxInt}");

            double maxDouble = Helper.Max(3.5, 7.2);
            Console.WriteLine($"Max double: {maxDouble}");

            string maxString = Helper.Max("Apple", "Banana");
            Console.WriteLine($"Max string: {maxString}");
            //Question
            //generics in C# can be constrained to specific types using where clauses.
            //This ensures type safety and allows generic methods or classes to use specific functionality.
            #endregion*/
            /*#region Problem12
            int[] numbers = { 1, 2, 3, 2, 4 };
            Helper2<int>.ReplaceArray(numbers, 2, 99);
            Console.WriteLine("Integers after replace: " + string.Join(", ", numbers));

            string[] names = { "Ahmed", "Sara", "Ahmed" };
            Helper2<string>.ReplaceArray(names, "Ahmed", "Mohamed");
            Console.WriteLine("Strings after replace: " + string.Join(", ", names));
            //Question
            //Generic classes define a type parameter for the entire class, so all members use the same type for that instance.
            //Generic methods define a type parameter for a single method, allowing each method call to use a different type.
            //Generic methods are more flexible for one - off operations, while generic classes are suitable when the class operates on a consistent type.
            #endregion*/
            /*#region Problem13
            Rectangle rect1 = new Rectangle(5, 10);
            Rectangle rect2 = new Rectangle(20, 15);

            Console.WriteLine("Before swap:");
            Console.WriteLine(rect1);
            Console.WriteLine(rect2);

            Utility.Swap(ref rect1, ref rect2);

            Console.WriteLine("\nAfter swap:");
            Console.WriteLine(rect1);
            Console.WriteLine(rect2);
            //Question
            //A generic swap method is preferable because it allows swapping values of any type without writing separate methods for each type.
            //It reduces code duplication, increases flexibility, and makes the code easier to maintain.
            #endregion*/
            /*#region Problem14
            Department depIT = new Department { Id = 1, Name = "IT" };
            Department depHR = new Department { Id = 2, Name = "HR" };

            Employee[] employees = new Employee[]
            {
            new Employee { Id = 1, Name = "Ahmed", Department = depIT },
            new Employee { Id = 2, Name = "Sara", Department = depHR },
            new Employee { Id = 3, Name = "Omar", Department = depIT }
            };

            // Search for IT department
            Employee searchEmp = new Employee { Department = new Department { Id = 1 } };
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Department.Equals(searchEmp.Department))
                {
                    Console.WriteLine($"Found: {employees[i]} at index {i}");
                }
            }
            //Question
            //Overriding Equals in the Department class improves search accuracy by allowing comparisons based on meaningful data(like Id) rather than object references.
            //Without overriding, two different Department objects with the same data would be considered unequal, leading to incorrect search results.
            #endregion*/
            /*#region Problem15
            CircleStruct c1 = new CircleStruct(5, "Red");
            CircleStruct c2 = new CircleStruct(5, "Red");

            Console.WriteLine("Struct comparison:");
            Console.WriteLine($"c1.Equals(c2): {c1.Equals(c2)}");// true, field-by-field
            
            Console.WriteLine("-------------------------------");
            CircleClass c3 = new CircleClass(5, "Red");
            CircleClass c4 = new CircleClass(5, "Red");

            Console.WriteLine("\nClass comparison:");
            Console.WriteLine($"c1.Equals(c2): {c3.Equals(c4)}"); // false by default, compares references
            Console.WriteLine($"c1 == c2: {c3 == c4}"); // false, compares references
            //Question
            //By default, == is not implemented for structs because structs can have multiple fields, and the compiler cannot assume which fields should be compared.
            //Equals for structs compares all fields automatically(field - by - field).
            //For classes, both == and Equals compare object references by default.
            //You can overload == for structs if you want a specific comparison behavior.
            #endregion*/
            #endregion
            #region Part02
            /*#region Problem1
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] reversedNumbers = ReverseArray(numbers);
            Console.WriteLine(string.Join(", ", reversedNumbers));
            #endregion*/
            /*#region Problem2
            GenericStack<int> stack = new GenericStack<int>(5);
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop()); 
            #endregion*/
            /*#region Problem3
            int[] arr = { 1, 2, 3, 4 };
            Swap(arr, 1, 3);
            Console.WriteLine(string.Join(", ", arr));
            #endregion*/
            /*#region Problem4
            int[] numbers = { 10, 25, 7, 30 };
            Console.WriteLine(Max(numbers)); // Output: 30

            string[] names = { "Moahmed", "Nagy", "Ahmed" };
            Console.WriteLine(Max(names));
            #endregion*/
            #endregion
        }
    }
}
