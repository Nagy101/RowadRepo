using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Xml;
using System.Xml.Linq;

namespace Day03Assi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*#region Problem1
            try
            {
                Console.WriteLine("Enter Your Number :)");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Convert With Parse :{number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error :{ex.Message}");
            }
            Console.WriteLine("-------------------------");
            try
            {
                Console.WriteLine("Enter Your Number2 :)");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Convert With 'convert' :{number2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error :{ex.Message}");
            }
            //Question
            //difference between it parse can`t acceopt null value but convert can accept null value
            Console.WriteLine("-----------------------------");
            string input = null;
            int num = Convert.ToInt32(input);
            Console.WriteLine($"Number with input null : {num}"); // 0
            #endregion*/
            /*#region Problem2
            Console.WriteLine("Enter Your Number :)");
            bool flag = int.TryParse(Console.ReadLine(), out int result);
            if (flag)
            {
                Console.WriteLine($"Your Number is : {result}");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
            //Question
            // TryParse is recommended because it does not throw an exception
            // when the user enters invalid data, unlike Parse which throws an exception.
            #endregion*/
            /*#region Problem3
            object data;
            data = "Hello World";
            Console.WriteLine(data.GetHashCode());//-862545276
            data = 123;
            Console.WriteLine(data.GetHashCode());//123
            data = 11.11;
            Console.WriteLine(data.GetHashCode());//-1415371031
            //Question
            //The GetHashCode() method returns an integer value that represents the object’s data.
            //Its main purpose is to optimize performance in hash-based collections.
            #endregion*/
            /*#region Problem4
            Point P1 = new Point();
            P1.x = 10;
            Point P2 = P1;
            P2.x = 20;
            Console.WriteLine(P1.x);
            //Question
            //Reference equality means that two references point to the same object in memory.
            //It is significant because changes made through one reference
            //will affect all other references to the same object.
            #endregion*/
            /*#region Problem5
            string str = "Welcome";
            Console.WriteLine(str.GetHashCode());
            str += " Hi Willy"; 
            Console.WriteLine(str.GetHashCode());
            //Question
            //A string is immutable in C# because any modification creates a new object
            //instead of changing the existing one.
            #endregion*/
            /*#region Problem6
            StringBuilder SB = new StringBuilder("Welcome ");
            Console.WriteLine(SB.GetHashCode());
            SB.Append(" Hi Willy");
            Console.WriteLine(SB.GetHashCode());
            //Question
            //StringBuilder addresses the inefficiency of string concatenation
            //by being mutable.
            //It modifies the same object in memory instead of creating new objects
            //for every change, which improves performance
            //and reduces memory usage when performing multiple string modifications.
            //Question2
            //StringBuilder is faster for large-scale string modificationsbecause it is mutable, 
            //allowing changes to be made to the same object in memory.
            //In contrast, string is immutable and creates a new objectfor every modification,
            //which increases memory usage and reduces performance.
            #endregion*/
            /*#region Problem7
            Console.Write("Enter Your 1st Number = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Your 2nd Number = ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum With Diff Formating :)");
            int sum = num1 + num2;  
            Console.WriteLine("Concatenation :" + sum);
            string result = string.Format("String Format : {0}",num1+num2);
            Console.WriteLine("Composite formatting" + result);
            Console.WriteLine($"String interpolation : {num1 + num2}");
            //Question
            //String interpolation($) is the most commonly used methodbecause it is more readable,
            //easier to write,and less error - prone than concatenation or composite formatting.
            #endregion*/
            /*#region Problem8
            StringBuilder SB = new StringBuilder("Hello");
            SB.Append(" World");
            Console.WriteLine(SB);
            SB.Replace("World", "Nagy");
            Console.WriteLine(SB);
            SB.Insert(5, " Mohamed");
            Console.WriteLine(SB);
            SB.Remove(5, 8);
            Console.WriteLine(SB);
            //Question
            //StringBuilder is designed for frequent string modifications because it is mutable.
            //Any change is made to the same object in memory without creating new objects,
            //which improves performance and reduces memory usage compared to immutable strings.
            #endregion*/

        }
    }
}
