using System;

namespace AssiDay05
{
    internal class Program
    {
        static void SumAndMultiply(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
        static void PrintText(string text, int count = 5)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(text);
        }
        static int SumArray(params int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
                sum += i;
            return sum;
        }
        static void Main(string[] args)
        {
            #region Part1
            /*#region Problem1
try
{
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine());

    int result = a / b;
    Console.WriteLine("Result = " + result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
finally
{
    Console.WriteLine("Operation complete");
}

//Question:
//The finally block is used to execute code whether an exception occurs or not.
#endregion*/
            /*#region Problem2
            int x, y;
            bool valid;

            do
            {
                Console.Write("Enter positive X: ");
                valid = int.TryParse(Console.ReadLine(), out x) && x > 0;
            } while (!valid);

            do
            {
                Console.Write("Enter Y (greater than 1): ");
                valid = int.TryParse(Console.ReadLine(), out y) && y > 1;
            } while (!valid);

            Console.WriteLine("X = " + x + ", Y = " + y);

            //Question:
            //int.TryParse prevents exceptions and safely handles invalid input.
            #endregion*/
            /*#region Problem3
            int? num = null;
            int value = num ?? 10;
            Console.WriteLine(value);

            if (num.HasValue)
                Console.WriteLine(num.Value);
            else
                Console.WriteLine("Value is null");

            //Question:
            //InvalidOperationException occurs when accessing Value while it is null.
            #endregion*/
            /*#region Problem4
            int[] arr = new int[5];

            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }

            //Question:
            //Checking bounds prevents runtime errors and program crashes.
            #endregion*/
            /*#region Problem5
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0, colSum = 0;
                for (int j = 0; j < 3; j++)
                {
                    rowSum += matrix[i, j];
                    colSum += matrix[j, i];
                }
                Console.WriteLine($"Row {i} Sum = {rowSum}, Column {i} Sum = {colSum}");
            }

            //Question:
            //GetLength(dimension) returns the size of a specific array dimension.
            #endregion*/
            /*#region Problem6
            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[1] = new int[3];
            jagged[2] = new int[1];

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = int.Parse(Console.ReadLine());
                }
            }

            foreach (var row in jagged)
            {
                foreach (var item in row)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
            //Question:
            //Jagged arrays allocate memory separately for each row unlike rectangular arrays.
            #endregion*/
            /*#region Problem7
            string? text = null;

            if (DateTime.Now.Day > 0)
                text = "Hello";

            Console.WriteLine(text!);

            //Question:
            //Nullable reference types help prevent null reference errors at compile time.
            #endregion*/
            /*#region Problem8
            int n = 5;
            object obj = n;

            try
            {
                int m = (int)obj;
                Console.WriteLine(m);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid cast.");
            }

            // Question:
            //Boxing and unboxing reduce performance due to memory allocation and type casting.
            #endregion*/
            /*#region Problem9
            SumAndMultiply(3, 4, out int sum, out int product);
            Console.WriteLine(sum + " " + product);

            //Question:
            //out parameters must be initialized inside the method before returning.
            #endregion*/
            /*#region Problem10
            PrintText("Hello", count: 3);

            //Question:
            //Optional parameters must be last to avoid ambiguity during method calls.
            #endregion*/
            /*#region Problem11
            int[]? numbers = null;
            Console.WriteLine(numbers?.Length);

            //Question:
            //It stops execution if the object is null and avoids NullReferenceException.
            #endregion*/
            /*#region Problem12
            Console.Write("Enter day: ");
            string day = Console.ReadLine();

            int dayNum = day switch
            {
                "Monday" => 1,
                "Tuesday" => 2,
                "Wednesday" => 3,
                "Thursday" => 4,
                "Friday" => 5,
                "Saturday" => 6,
                "Sunday" => 7,
                _ => 0
            };

            Console.WriteLine(dayNum);

            //Question:
            //Switch expressions are cleaner and more readable for fixed mappings.
            #endregion*/
            /*#region Problem13
            Console.WriteLine(SumArray(1, 2, 3));
            Console.WriteLine(SumArray(new int[] { 4, 5, 6 }));

            //Question:
            //params must be the last parameter and only one params is allowed.
            #endregion*/
            #endregion
            #region Part2
            /*#region Problem1
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i < n) Console.Write(", ");
            }
            Console.WriteLine();
            #endregion*/
            /*#region Problem2
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(num * i);
                if (i < 12) Console.Write(", ");
            }
            Console.WriteLine();
            #endregion*/
            /*#region Problem3
            Console.Write("Enter a number: ");
            int limit = int.Parse(Console.ReadLine());

            for (int i = 2; i <= limit; i += 2)
            {
                Console.Write(i);
                if (i + 2 <= limit) Console.Write(", ");
            }
            Console.WriteLine();
            #endregion*/
            /*#region Problem4
            Console.Write("Enter base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Enter power: ");
            int power = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine(result);
            #endregion*/
            /*#region Problem5
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
            #endregion*/
            /*#region Problem6
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + (number % 10);
                number /= 10;
            }

            Console.WriteLine(reversed);
            #endregion*/
            /*#region Problem7
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxDistance = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i - 1;
                        if (distance > maxDistance)
                            maxDistance = distance;
                        break;
                    }
                }
            }

            Console.WriteLine("Longest Distance = " + maxDistance);
            #endregion*/
             /*#region Problem8
            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i]);
                if (i > 0) Console.Write(" ");
            }
            Console.WriteLine();
            #endregion*/
            #endregion
        }
    }
}
