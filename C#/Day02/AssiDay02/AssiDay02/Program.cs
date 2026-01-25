using System;

namespace AssiDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part01
            /*#region Problem1
            // Decler Variable x and Assign Value 10 to x
            int x = 10;
            // Decler Variable X and Assign Value 20 to y
            int y = 20;
            // Decler Variable sum and Assign Value of x + y to sum
            int sum = x + y;
            // Print the value of sum
            Console.WriteLine(sum);
            //Question :-
            //ShortCut : Ctrl + K + C to comment and Ctrl + K + U to uncomment
            #endregion*/
            /*#region Problem2
            // Can`t Assign string value to int variable
            //int x = "10";
            int x = 10;
            // Can`t Print variable without Decler it and Assign Value
            //Console.WriteLine(x + y);
            int y = 20;
            Console.WriteLine(x +  y);
            //Question :-
            // runtime error 
            // A runtime error happens when you run the code and an unexpected problem occurs during execution.
            //Example:-
            int a = 10;
            int b = 0;
            Console.WriteLine(a/b); //Runtime Error
            // Logical Error
            //A logical error happens when the program runs without crashing, but the output is wrong because of incorrect logic.
            //To fix it, you need to trace and debug the code.
            //Example:-
            int c = 20;
            int avg = (a + b + c); // Logical Error
            Console.WriteLine(avg);
            #endregion*/
            /*#region Problem3
            Console.WriteLine("Enter Your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Salary");
            decimal Salary = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("You Are Student? Yes = 1 || No = 0");
            int StudentInput = Int32.Parse(Console.ReadLine());
            bool Student = (StudentInput == 1);

            Console.WriteLine($"Name   : {Name}");
            Console.WriteLine($"Age    : {Age}");
            Console.WriteLine($"Salary : {Salary}");

            if (Student) {
                Console.WriteLine("I`m a Student");
            }
            else
            {
                Console.WriteLine("I`m not a Student");
            }
            //Question :-
            //PascalCase makes your code cleaner, clearer, more professional, and easier to maintain.
            #endregion*/
            /*#region Problem4
            // Value Type Example
            // Value types are stored in the stack.
            // Changing one variable does not affect another variable.
            int x = 10;
            int y = 20;
            x = y;    // Copy the value of y into x
            y = 30;   // Changing y does not affect x
            Console.WriteLine(x); // 20
            Console.WriteLine(y); // 30
            Console.WriteLine("-----------------------------");

            // Reference Type Example
            // Reference types are stored in the heap.
            // Variables store a reference (address) to the object.
            // Changing the object via one reference affects all references pointing to it.
            Point P1 = new Point();
            P1.x = 20;
            Point P2 = new Point();
            P2 = P1;      // P2 now points to the same object as P1
            P2.x = 30;    // Changing the object via P2 affects P1 as well
            Console.WriteLine(P1.x); // 30
            Console.WriteLine(P2.x); // 30
            #endregion*/
            /*#region Problem5
            int x = 15;
            int y = 4;

            // Sum
            int Sum = x + y;
            Console.WriteLine($"Sum: {Sum}");

            // Difference
            int Difference = x - y;
            Console.WriteLine($"Difference: {Difference}");

            // Product
            int Product = x * y;
            Console.WriteLine($"Product: {Product}");

            // Division
            int Division = x / y;
            Console.WriteLine($"Division: {Division}");

            // Remainder
            int Remainder = x % y;
            Console.WriteLine($"Remainder: {Remainder}");

            //Question:-
            // If the first number is less than the second, the remainder is the first number.
            int a = 2, b = 7;
            Console.WriteLine(a % b); // 2 
            #endregion*/
            /*#region Problem6
            Console.WriteLine("Enter A Number :)");
            int x = Int32.Parse(Console.ReadLine());
            if (x > 10 && x%2 == 0)
            {
                Console.WriteLine("Your Number is Even and Greater than 10 ");
            }
            else {
                Console.WriteLine("Your number doesn`t mach the conditions (either < 10 or not Even).");
            }
            //Question:-
            //"&& is a logical AND that stops if the first condition is false,
            //while & checks both conditions or does bitwise AND on numbers."
            //Example
            bool a = true;
            bool b = false;
            Console.WriteLine(a & b); 
            #endregion*/
            /*#region Problem7
            Console.WriteLine("Enter a Number :)");
            int Num = Int32.Parse(Console.ReadLine());
            double Num2 = Num;
            Console.WriteLine($" This is implicit cast : {Num2}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Enter a Decimal Number :)");
            double Number = double.Parse(Console.ReadLine());
            int Number2 = (int)Number;
            Console.WriteLine($" This is explicit cast : {Number2}");
            //Question:-
            //"Explicit casting is required because converting a double to an int may lose the fractional part
            //and the compiler needs you to confirm the conversion."
            #endregion*/
            /*#region Problem8
            Console.WriteLine("Enter Your Age :)");
            try
            {
                int Age = Int32.Parse(Console.ReadLine());

                if (Age > 0)
                {
                    if (Age >= 18)
                        Console.WriteLine($"Age: {Age}");
                    else
                        Console.WriteLine("Your Age is less than 18");
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input :( Please enter a valid number.");
            }
            //Question
            //A FormatException might occur if the input is not a valid number. You can handle it using a try-catch block.
            #endregion*/
            /*#region Problem9
            // Prefix increment: variable is incremented before being used
            //int x = 2;
            //Console.WriteLine($"Prefix :) {++x}"); // 
            //Console.WriteLine("-------------------");

            //// Postfix increment: variable is used first, then incremented
            //Console.WriteLine($"Postfix :) {x++}"); // prints 3, then becomes 4
            //Console.WriteLine($"Value of x after Postfix: {x}"); // 4

            //Question
            int x = 5;
            int y = ++x + x++; //6 + 6 =12 || x = 7
            Console.WriteLine(x);
            Console.WriteLine(y);
            #endregion*/
        }
    }
}
