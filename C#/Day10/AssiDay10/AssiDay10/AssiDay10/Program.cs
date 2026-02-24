using AssiDay10.Classes;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace AssiDay10
{
    internal class Program
    {
        #region Problem9
        public static T GetDefault<T>()
        {
            return default(T);
        } 
        #endregion
        #region Problem11
        delegate string StringTransformer(string input);
        static List<string> TransformStrings(List<string> list, StringTransformer transformer)
        {
            List<string> result = new List<string>();

            foreach (string item in list)
            {
                result.Add(transformer(item));
            }

            return result;
        }
        #endregion
        #region Problem12
        delegate int MathOperation(int x, int y);
        static int Calculate(int a, int b, MathOperation operation)
        {
            return operation(a, b);
        }
        #endregion
        #region Problem13
        delegate R Transformer<T, R>(T input);
        static List<R> TransformList<T, R>(List<T> source,Transformer<T, R> transformer)
        {
            List<R> result = new List<R>();

            foreach (T item in source)
            {
                result.Add(transformer(item));
            }

            return result;
        }
        #endregion
        #region Problem14
        static List<int> ApplySquare(List<int> numbers,Func<int, int> operation)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                result.Add(operation(number));
            }
            return result;
        }
        #endregion
        #region Problem15
        static void ApplyAction(List<string> list, Action<string> action)
        {
            foreach (var item in list)
            {
                action(item); 
            }
        }
        #endregion
        #region Problem16
        static List<int> FilterList(List<int> numbers, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (var n in numbers)
            {
                if (predicate(n))
                {
                    result.Add(n);
                }
            }

            return result;
        }
        #endregion
        #region Problem17
        static List<string> FilterStrings(List<string> list, Func<string, bool> condition)
        {
            List<string> result = new List<string>();

            foreach (var item in list)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        #endregion
        #region Problem20
        static double Calculate(double a, double b, Func<double, double, double> operation)
        {
            return operation(a, b);
        }
        #endregion
        static void Main(string[] args)
        {
            /*#region Problem1
            Employee[] employees =
            {
                new Employee("Moahmed", 8000),
                new Employee("Nagy", 5000),
                new Employee("Omar", 10000)
            };
            SortingAlgorithm<Employee> sorting = new SortingAlgorithm<Employee>();
            sorting.Sort(employees, (e1, e2) => e1.Salary.CompareTo(e2.Salary));
            Console.WriteLine("Employees sorted by salary:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}: {employee.Salary}");
            }
            //Question:
            //Using a generic sorting algorithm provides better reusability, type safety, and performance.
            //It allows the same sorting logic to work with different data types without rewriting code.
            //Generics also prevent runtime casting errors and improve code maintainability and flexibility.
            #endregion*/
            /*#region Problem2
            int[] numbers = { 3, 10, 1, 7 };

            SortingAlgorithm<int> sortingDec = new SortingAlgorithm<int>();

            sortingDec.Sort(
                numbers,
                (x, y) => y.CompareTo(x) 
            );

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Question:
            //Lambda expressions improve the readability of sorting methods by expressing comparison logic in a clear and concise way.
            //They increase flexibility by allowing different sorting behaviors(ascending, descending or custom) without modifying the sorting algorithm itself.
            //This results in cleaner, more maintainable, and reusable code.
            #endregion*/
            /*#region Problem3
            string[] names = { "Moahmed", "Nagy", "Ahmed", "Omar" };
            SortingAlgorithm<string> sortingString = new SortingAlgorithm<string>();
            sortingString.Sort(names,
                (n1, n2) => n1.Length.CompareTo(n2.Length));
            Console.WriteLine("Names sorted by length:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            //Question:
            //A dynamic comparer allows flexible sorting for different data types and criteria.
            //It separates comparison logic from the sorting algorithm, improving reusability and maintainability.
            #endregion*/
            /*#region Problem4
            Manager[] managers =
            {
                    new Manager("Moahmed", 8000),
                    new Manager("Nagy", 12000),
                    new Manager("Omar", 5000)
            };
            Array.Sort(managers);
            Console.WriteLine("Managers sorted by salary:");
            foreach (var manager in managers)
            {
                Console.WriteLine($"{manager.Name}: {manager.Salary}");
            }
            //Question:
            //Implementing IComparable<T> in derived classes lets each object define its own comparison logic.
            //This enables automatic sorting based on custom criteria, like Salary, without needing an external comparer.
            #endregion*/
            /*#region Problem5
            Employee[] employees =
            {
                new Employee ("Moahmed",8000 ),
                new Employee ("Nagy",5000 ),
                new Employee ("Omar",10000 )
            };
            Func<Employee,Employee,bool> compareWithName = (e1, e2) => e1.Name.Length > e2.Name.Length;
            SortingAlgorithm<Employee> sorting = new SortingAlgorithm<Employee>();
            sorting.Sort(employees, (e1, e2) => compareWithName(e1, e2) ? 1 : -1);
            Console.WriteLine("Employees sorted by name length:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}: {employee.Salary}");
            }

            #endregion*/
            /*#region Problem6
            int[] numbers = { 5, 2, 9, 1, 3 };
            SortingAlgorithm<int> sortingInt = new SortingAlgorithm<int>();
            sortingInt.Sort(numbers, delegate (int x, int y)
            {
                return x.CompareTo(y);
            });
            Console.WriteLine("Numbers sorted in ascending order:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Question:
            //Lambda expressions are more concise and readable than anonymous functions, while both have similar performance.
            //Lambdas are preferred in modern C# for cleaner and more maintainable code.
            #endregion*/
            /*#region Problem7
            int[] numbers = { 10, 5 };

            SortingAlgorithm<int> sorter = new SortingAlgorithm<int>();
            sorter.Swap(ref numbers[0], ref numbers[1]);

            Console.WriteLine(numbers[0]); 
            Console.WriteLine(numbers[1]);
            //Question:
            //Generic methods like Swap<T> improve reusability and type safety by working with any data type.
            //They reduce code duplication and help create clean, maintainable utility functions.
            #endregion*/
            /*#region Problem8
            Employee[] employees =
            {
                new Employee("Moahmed", 8000),
                new Employee("Nagy", 3000),
                new Employee("Omar", 10000)
            };
            SortingAlgorithm<Employee> sorter = new SortingAlgorithm<Employee>();

            sorter.Sort(employees, (e1, e2) =>
            {
                int salaryResult = e1.Salary.CompareTo(e2.Salary);

                if (salaryResult != 0)
                    return salaryResult;   
                return e1.Name.CompareTo(e2.Name);
            });

            Console.WriteLine("Employees sorted by salary and then by name:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}: {employee.Salary}");
            }
            //Question:
            //Multi - criteria sorting increases flexibility and reusability in generic methods.
            //However, it requires careful comparison logic to avoid complexity and maintain correct ordering.
            #endregion*/
            /*#region Problem9
            int x = GetDefault<int>();
            double d = GetDefault<double>();
            string b = GetDefault<string>();

            Console.WriteLine($"Default int: {x}");
            Console.WriteLine($"Default double: {d}");
            Console.WriteLine($"Default string: {b}");
            //Question:
            //default(T) is essential in generic programming because it allows returning a safe default value without knowing the actual type at compile time.
            #endregion*/
            /*#region Problem10
            Employee[] employees =
            {
                new Employee("Ahmed", 8000),
                new Employee("Mohamed", 12000),
                new Employee("Omar", 5000)
            };

            Employee[] clonedEmployees = new Employee[employees.Length];

            for (int i = 0; i < employees.Length; i++)
            {
                clonedEmployees[i] = (Employee)employees[i].Clone();
            }

            SortingAlgorithm<Employee> sorting = new SortingAlgorithm<Employee>();

            sorting.Sort(clonedEmployees,
                (e1, e2) => e1.Salary.CompareTo(e2.Salary));

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}: {employee.Salary}");
            }
            //Question:
            //Generic constraints ensure type safety by restricting the types that can be used with a generic class or method.
            #endregion*/
            /*#region Problem11
            List<string> names = new List<string>
            {
                "mohamed",
                "nagy",
                "omar"
            };
            StringTransformer toUpper = s => s.ToUpper();

            List<string> upperNames = TransformStrings(names, toUpper);
            Console.WriteLine("Transformed Names: ");
            foreach (var name in upperNames)
            {
                Console.WriteLine(name);
            }
            //Question:
            //Delegates allow passing behavior as a parameter, enabling flexible and reusable string transformations.
            //This functional approach improves readability, reduces code duplication, and makes the code easier to extend.
            #endregion*/
            /*#region Problem12
            int resultAdd = Calculate(10, 5, (x, y) => x + y);
            Console.WriteLine(resultAdd);
            Console.WriteLine("--------------");
            
            int resultSub = Calculate(10, 5, (x, y) => x - y);
            Console.WriteLine(resultSub);
            Console.WriteLine("--------------");

            int resultMul = Calculate(10, 5, (x, y) => x * y);
            Console.WriteLine(resultMul); 
            Console.WriteLine("--------------");

            int resultDiv = Calculate(10, 5, (x, y) => x / y);
            Console.WriteLine(resultDiv);
            //Question:
            //Delegates promote code reusability by allowing the same method to perform different operations without modification.
            //They improve flexibility by enabling behavior to be passed dynamically, making the code easier to extend and maintain.
            #endregion*/
            /*#region Problem13
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            List<string> stringNumbers = TransformList(numbers,(n) => n.ToString());
            foreach (var str in stringNumbers)
            {
                Console.WriteLine(str);
            }
            //Question:
            //Generic delegates enable type-safe and reusable transformations across different data types.
            //They increase flexibility, reduce code duplication, and make data processing more extensible.
            #endregion*/
            /*#region Problem14
            Func<int, int> square = x => x * x;

            List<int> nums = new List<int> { 1, 2, 3, 4 };
            List<int> squaredNums = ApplySquare(nums, square);
            Console.WriteLine("Squared Numbers:");
            foreach (var num in squaredNums)
            {
                Console.WriteLine(num);
            }
            //Question:
            //Func simplifies delegate usage by providing built-in,
            //strongly typed delegates that reduce boilerplate code and integrate seamlessly with lambda expressions,improving readability and productivity.
            #endregion*/
            /*#region Problem15
            Action<string> print = s => Console.WriteLine(s);
            List<string> names = new List<string> { "Ahmed", "Moahmed", "Omar" };

            ApplyAction(names, print);
            //Question:
            //Action is preferred for operations that do not return values because it provides a built-in,
            //concise delegate for performing side-effect operations, improving code readability and reusability.
            #endregion*/
            /*#region Problem16
            Predicate<int> isEven = n => n % 2 == 0;

            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<int> evenNumbers = FilterList(nums, isEven);

            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
            //Question:
            //Predicates encapsulate conditions as delegates, enabling flexible and reusable filtering in functional programming.
            //They improve code clarity by separating the logic of the condition from the execution flow.
            #endregion*/
            /*#region Problem17
            List<string> names = new List<string>
            {
                "Ahmed","Omar","Sara","Ali","Sami"
            };

            List<string> startWithA = FilterStrings( names, delegate (string s) { return s.StartsWith("A"); });

            Console.WriteLine("Names starting with A:");
            foreach (var n in startWithA)
                Console.WriteLine(n);

            List<string> containsS = FilterStrings(names,s => s.Contains("S") || s.Contains("s"));

            Console.WriteLine("Names containing S:");
            foreach (var n in containsS)
                Console.WriteLine(n);
            //Question:
            //Anonymous functions improve modularity by allowing custom logic to be passed directly into methods.
            //They enhance code flexibility, reduce boilerplate, and make functions reusable with different conditions.
            #endregion*/
            /*#region Problem18
            int sum = Calculate(10, 5, (x, y) => x + y);
            Console.WriteLine($"Sum :{sum}");

            int diff = Calculate(10, 5, (x, y) => x - y);
            Console.WriteLine($"Diff :{diff}");

            int product = Calculate(10, 5, (x, y) => x * y);
            Console.WriteLine($"Product :{product}");
            //Question:
            //Anonymous functions are preferred when operations are simple, temporary, and used locally.
            //They reduce boilerplate, improve readability, and allow flexible, inline definition of behavior.
            #endregion*/
            /*#region Problem19
            List<string> words = new List<string> { "apple", "bat", "elephant", "cat", "bee" };

            List<string> longWords = FilterStrings(words, s => s.Length > 3);

            Console.WriteLine("Words longer than 3 characters:");
            foreach (var word in longWords)
                Console.WriteLine(word);
            //Question:
            //Lambda expressions provide concise, readable, and inline function definitions.
            //They enable passing behavior as parameters, support functional programming, and enhance code flexibility and maintainability.
            #endregion*/
            /*#region Problem20
            double division = Calculate(10.0, 2.0, (x, y) => x / y);
            Console.WriteLine($"Division :{division}");

            double power = Calculate(2.0, 3.0, (x, y) => Math.Pow(x, y));
            Console.WriteLine($"Power :{power}");
            //Question:
            //Lambda expressions enhance mathematical computations by enabling concise, inline definitions of operations.
            //They increase expressiveness, reduce boilerplate, and allow flexible, dynamic behavior in calculations.
            #endregion*/
        }
    }
}
