using System;

namespace AssiDay04
{
    internal class Program
    {
        enum DayOfWeek { Saturday=1 , Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };
        static void Main(string[] args)
        {
            /*#region Problem1
            //1st way
            int[] arr1 = new int[5] { 1,2,3,4,5 };
            Console.WriteLine("Array 1 :)");
            foreach (int item in arr1)
            { 
                Console.WriteLine(item);
            }
            //2nd way
            Console.WriteLine("Array 2 :)");
            int[] arr2 = new int[3];
            arr2[0] = 10;
            arr2[1] = 20;
            arr2[2] = 30;
            foreach (int item in arr2)
            {
                Console.WriteLine(item);
            }
            //3rd way
            int[] arr3 = { 100, 200, 300 };
            Console.WriteLine("Array 3 :)");
            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arr3[3]); // This will throw an IndexOutOfRangeException
            //Question
            //array elements are automatically initialized with default values depending on their data type
            //0 for numeric types, false for bool, and null for reference types
            //Example
            int[] arr2 = new int[2];
            Console.WriteLine(arr2[0]); // 0
            Console.WriteLine(arr2[1]); // 0
            #endregion*/
            /*#region Problem2
            //Shallow Copy Example
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //arr2 = arr1;
            //Console.WriteLine("Before modification:");
            //Console.WriteLine($"arr1[0] = {arr1[0]}");
            //Console.WriteLine($"arr2[0] = {arr2[0]}");
            //arr2[0] = 10;
            //Console.WriteLine("After modification:");
            //Console.WriteLine($"arr1[0] = {arr1[0]}");
            //Console.WriteLine($"arr2[0] = {arr2[0]}");
            //Deep Copy Example
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            arr2 = (int[])arr1.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine($"arr1[0] = {arr1[0]}");
            Console.WriteLine($"arr2[0] = {arr2[0]}");
            arr2[0] = 10;
            Console.WriteLine("After modification:");
            Console.WriteLine($"arr1[0] = {arr1[0]}");
            Console.WriteLine($"arr2[0] = {arr2[0]}");
            //Question
            //Array.Clone() creates a new array and copies all elements but returns an object
            //Array.Copy() copies elements from one array to another with more control and does not return a value.
            int[] arr3 = { 1, 2, 3 };
            int[] arr4 = new int[3];

            Array.Copy(arr3, arr4, 3);

            Console.WriteLine("Example for Array.Copy:");
            Console.WriteLine($"arr3[0] = {arr3[0]}");
            Console.WriteLine($"arr3[1] = {arr3[1]}");
            Console.WriteLine($"arr3[2] = {arr3[2]}");
          #endregion*/
            /*#region Problem3
            int[,] Grades = new int[3, 3];
            for(int i =0;i < Grades.GetLength(0); i++)
            {
                for(int j=0;j< Grades.GetLength(1);j++)
                {
                    Console.WriteLine($"Enter grade for Student {i+1}, Subject {j+1}: ");
                    Grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("---------------------");
            }
            //Question
            //Length gives the total number of elements
            //GetLength(dimension) gives the size of a specific dimension. (0) for rows, (1) for columns
            #endregion*/
            /*#region Problem4
            int[] arr = { 2, 50, 6, 3, 40 };

            #region Sort
            Console.WriteLine("Array before Sort:");
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            Array.Sort(arr);

            Console.WriteLine("Array after Sort:");
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine("\n");
            #endregion
            #region Reverse
            Console.WriteLine("Array before Reverse:");
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            Array.Reverse(arr); 

            Console.WriteLine("Array after Reverse:");
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine("\n");
            #endregion
            #region IndexOf
            int index = Array.IndexOf(arr, 40); 
            Console.WriteLine($"Index of 40: {index}\n");
            #endregion
            #region Copy
            int[] arr2 = new int[3];
            Array.Copy(arr, arr2, 3); 

            Console.WriteLine("Array 2 after Copy:");
            foreach (int item in arr2)
                Console.Write(item + " ");
            Console.WriteLine("\n");
            #endregion
            #region Clear
            Array.Clear(arr, 1, 3); 

            Console.WriteLine("Array after Clear:");
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion
            //Question
            //Array.Copy() copies elements, but if an error happens, some items may copy and some not.
            //Array.ConstrainedCopy() copies everything or nothing, so the array stays unchanged on error.
            #endregion*/
            /*#region Problem5
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Print With For Loop");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Print With Foreach Loop");
            foreach (int item in arr)
                Console.WriteLine(item);

            Console.WriteLine("Print With While Loop");
            int j = 0;
            while ( j < arr.Length)
            {
                Console.WriteLine(arr[j]);
                j++;
            }
            //Question
            //foreach is preferred for read-only operations on arrays because it’s simple,
            //avoids index errors, and prevents accidental modification of the array elements.

            #endregion*/
            /*#region Problem6
            bool flag;
            int result;
            do
            {
                Console.WriteLine("Enter positive odd number :)");
                flag = int.TryParse(Console.ReadLine(), out result);
            }
            while (!flag || result <= 0 || result % 2 == 0);

            Console.WriteLine($"Valid input: {result}");
            //Question
            //because user input cannot be trusted avoids unexpected behavior
            //and the program works correctly and safely.
            #endregion*/
            /*#region Problem7
            int[,] arr = { { 1, 2, 3 },{ 4, 5, 6 }, { 7, 8, 9 }};
            for(int i=0;i<arr.GetLength(0); i++)
            {
                for(int j =0;j< arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            //Question
            //By printing each row on a separate line and using spacing or tabs between elements
            //the 2D array appears in a clear matrix format that is easy to read.
            #endregion*/
            /*#region Problem8
            #region If-Else
            Console.WriteLine("Enter month number (1 - 12):");
            int month = int.Parse(Console.ReadLine());

            if (month == 1)
                Console.WriteLine("January");
            else if (month == 2)
                Console.WriteLine("February");
            else if (month == 3)
                Console.WriteLine("March");
            else if (month == 4)
                Console.WriteLine("April");
            else if (month == 5)
                Console.WriteLine("May");
            else if (month == 6)
                Console.WriteLine("June");
            else if (month == 7)
                Console.WriteLine("July");
            else if (month == 8)
                Console.WriteLine("August");
            else if (month == 9)
                Console.WriteLine("September");
            else if (month == 10)
                Console.WriteLine("October");
            else if (month == 11)
                Console.WriteLine("November");
            else if (month == 12)
                Console.WriteLine("December");
            else
                Console.WriteLine("Invalid month number");

        #endregion
            #region Switch
            Console.WriteLine("Enter month number (1 - 12):");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1: Console.WriteLine("January");
                    break;
                case 2: Console.WriteLine("February");
                    break;
                case 3: Console.WriteLine("March");
                    break;
                case 4: Console.WriteLine("April"); 
                    break;
                case 5: Console.WriteLine("May");
                    break;
                case 6: Console.WriteLine("June");
                    break;
                case 7: Console.WriteLine("July");
                    break;
                case 8: Console.WriteLine("August");
                    break;
                case 9: Console.WriteLine("September");
                    break;
                case 10: Console.WriteLine("October");
                    break;
                case 11: Console.WriteLine("November");
                    break;
                case 12: Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }

            #endregion
            //Question
            //switch statement wins when you are comparing one variable against many fixed values
            //because it is cleaner, easier to read and easier to maintain than multiple if-else statements.
            #endregion*/
            /*#region Problem9
            int[] arr = { 5, 3, 8, 3, 1, 9, 3 };

            Array.Sort(arr);

            Console.WriteLine("Sorted Array:");
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n\nEnter number to search:");
            int value = int.Parse(Console.ReadLine());

            int firstIndex = Array.IndexOf(arr, value);
            int lastIndex = Array.LastIndexOf(arr, value);

            Console.WriteLine($"First Index: {firstIndex}");
            Console.WriteLine($"Last Index : {lastIndex}");
            //Question
            //The time complexity of Array.Sort() is O(n log n)


            #endregion*/
            /*#region Problem10
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum with for loob");
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
                sum += arr[i];
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine("Sum with foreach loop");
            sum = 0;
            foreach(int item in arr)
                sum += item;
            Console.WriteLine($"Sum = {sum}");
            //Question
            //for loop is  more efficient because it accesses array elements directly by index.
            //foreach is more readable, but it has a small overhead due to the enumerator.
            #endregion*/
            /*#region Problem2Part2
            int dayNum;
            bool flag;
            do
            {
                Console.WriteLine("Enter number from (1-7)");
                flag = int.TryParse(Console.ReadLine(), out dayNum);
            }
            while (!flag || dayNum < 1 || dayNum > 7);
            Console.WriteLine($"Day you choose {(DayOfWeek)dayNum}");
            //Question
            //If the user enters a value outside the range of 1 to 7, the do-while loop will
            //keep asking for input until the user enters a valid number within the allowed range.
            //The program will not continue or crash because the input is validated using int.
            //TryParse and range checking.
            #endregion*/
        }
    }
}
