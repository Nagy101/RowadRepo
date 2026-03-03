using LINQAssiDay02;
using System;
using System.IO;
using System.Linq;
namespace LINQAssiDay02
{
    class Program
    {
        static void Main()
        {
            var products = ListGenerators.ProductList;
            var customers = ListGenerators.CustomerList;

            /*#region LINQ Restriction Operators
            #region Problem1
            Console.WriteLine("Products Out Of Stock:");
            var r1 = products.Where(p => p.UnitsInStock == 0);
            foreach (var p in r1)
                Console.WriteLine(p);
            Console.WriteLine();
            #endregion
            #region Problem2
            Console.WriteLine("In Stock & Price > 3:");
            var r2 = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            foreach (var p in r2)
                Console.WriteLine(p);
            Console.WriteLine();
            #endregion
            #region Problem3
            Console.WriteLine("Digit Name Length < Value:");
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var r3 = digits.Where((d, i) => d.Length < i);
            foreach (var d in r3)
                Console.WriteLine(d);
            Console.WriteLine();
            #endregion
            #endregion*/
            /*#region LINQ Element Operators
            #region Problem1
            Console.WriteLine("Element:");
            Console.WriteLine(products.FirstOrDefault(p => p.UnitsInStock == 0));
            Console.WriteLine();
            #endregion
            #region Problem2
            Console.WriteLine("Element:");
            Console.WriteLine(products.FirstOrDefault(p => p.UnitPrice > 1000));
            Console.WriteLine();
            #endregion
            #region Problem3
            Console.WriteLine("Element:");
            int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine(nums.Where(n => n > 5).Skip(1).FirstOrDefault());
            Console.WriteLine();
            #endregion
            #endregion*/
            /*#region LINQ Aggregate Operators
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            string[] words = File.Exists("dictionary_english.txt")
            ? File.ReadAllLines("dictionary_english.txt")
            : new string[] { "apple", "banana", "computer", "science", "linq" };

            #region Problem1
            Console.WriteLine("Count Odd Numbers:");
            Console.WriteLine(Arr.Count(n => n % 2 != 0));
            Console.WriteLine();
            #endregion
            #region Problem2
            Console.WriteLine("Customers Orders Count:");
            var p2 = customers.Select(c => new { c.Name, Count = c.Orders.Length });
            foreach (var c in p2)
                Console.WriteLine($"{c.Name} => {c.Count}");
            Console.WriteLine();
            #endregion
            #region Problem3
            Console.WriteLine("Categories Products Count:");
            var p3 = products.GroupBy(p => p.Category);
            foreach (var g in p3)
                Console.WriteLine($"{g.Key} => {g.Count()}");
            Console.WriteLine();
            #endregion
            #region Problem4
            Console.WriteLine("Sum Of Numbers:");
            Console.WriteLine(Arr.Sum());
            Console.WriteLine();
            #endregion
            #region Problem5
            Console.WriteLine("Total Characters:");
            Console.WriteLine(words.Sum(w => w.Length));
            Console.WriteLine();
            #endregion
            #region Problem6
            Console.WriteLine("Units In Stock Per Category:");
            var p6 = products.GroupBy(p => p.Category);
            foreach (var g in p6)
                Console.WriteLine($"{g.Key} => {g.Sum(p => p.UnitsInStock)}");
            Console.WriteLine();
            #endregion
            #region Problem7
            Console.WriteLine("Shortest Word Length:");
            Console.WriteLine(words.Min(w => w.Length));
            Console.WriteLine();
            #endregion
            #region Problem8
            Console.WriteLine("Cheapest Price Per Category:");
            foreach (var g in products.GroupBy(p => p.Category))
                Console.WriteLine($"{g.Key} => {g.Min(p => p.UnitPrice)}");
            Console.WriteLine();
            #endregion
            #region Problem9
            Console.WriteLine("Cheapest Products Per Category:");
            var p9 =
                from p in products
                group p by p.Category into g
                let minPrice = g.Min(x => x.UnitPrice)
                select new
                {
                    Category = g.Key,
                    Products = g.Where(x => x.UnitPrice == minPrice)
                };

            foreach (var g in p9)
            {
                Console.WriteLine(g.Category);
                foreach (var p in g.Products)
                    Console.WriteLine($"  {p.ProductName} - {p.UnitPrice}");
            }
            Console.WriteLine();
            #endregion
            #region Problem10
            Console.WriteLine("Longest Word Length:");
            Console.WriteLine(words.Max(w => w.Length));
            Console.WriteLine();
            #endregion
            #region Problem11
            Console.WriteLine("Most Expensive Price Per Category:");
            foreach (var g in products.GroupBy(p => p.Category))
                Console.WriteLine($"{g.Key} => {g.Max(p => p.UnitPrice)}");
            Console.WriteLine();
            #endregion
            #region Problem12
            Console.WriteLine("Most Expensive Products Per Category:");
            var p12 =
                from p in products
                group p by p.Category into g
                let maxPrice = g.Max(x => x.UnitPrice)
                select new
                {
                    Category = g.Key,
                    Products = g.Where(x => x.UnitPrice == maxPrice)
                };

            foreach (var g in p12)
            {
                Console.WriteLine(g.Category);
                foreach (var p in g.Products)
                    Console.WriteLine($"  {p.ProductName} - {p.UnitPrice}");
            }
            Console.WriteLine();
            #endregion
            #region Problem13
            Console.WriteLine("Average Word Length:");
            Console.WriteLine(words.Average(w => w.Length));
            Console.WriteLine();
            #endregion
            #region Problem14
            Console.WriteLine("Average Price Per Category:");
            foreach (var g in products.GroupBy(p => p.Category))
                Console.WriteLine($"{g.Key} => {g.Average(p => p.UnitPrice)}");
            Console.WriteLine();
            #endregion
            #endregion*/
            /*#region LINQ Ordering Operators
            string[] words1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Problem1
            Console.WriteLine("Sort Products By Name:");
            var p1 = products.OrderBy(p => p.ProductName);
            foreach (var p in p1)
                Console.WriteLine(p.ProductName);
            Console.WriteLine();
            #endregion
            #region Problem2
            Console.WriteLine("Case Insensitive Sort:");
            var p2 = words1.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var w in p2)
                Console.WriteLine(w);
            Console.WriteLine();
            #endregion
            #region Problem3
            Console.WriteLine("Sort By Units In Stock Desc:");
            var p3 = products.OrderByDescending(p => p.UnitsInStock);
            foreach (var p in p3)
                Console.WriteLine($"{p.ProductName} => {p.UnitsInStock}");
            Console.WriteLine();
            #endregion
            #region Problem4
            Console.WriteLine("Digits By Length Then Name:");
            var p4 = digits.OrderBy(d => d.Length).ThenBy(d => d);
            foreach (var d in p4)
                Console.WriteLine(d);
            Console.WriteLine();
            #endregion
            #region Problem5
            Console.WriteLine("Problem 5 - Word Length Then Case Insensitive:");
            var p5 = words1
                .OrderBy(w => w.Length)
                .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var w in p5)
                Console.WriteLine(w);
            Console.WriteLine();
            #endregion
            #region Problem6
            Console.WriteLine("Category Then Price Desc:");
            var p6 = products
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.UnitPrice);
            foreach (var p in p6)
                Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            Console.WriteLine();
            #endregion
            #region Problem7
            Console.WriteLine("Word Length Then Desc:");
            var p7 = words1
                .OrderBy(w => w.Length)
                .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var w in p7)
                Console.WriteLine(w);
            Console.WriteLine();
            #endregion
            #region Problem8
            Console.WriteLine("Second Letter 'i' Reversed:");
            var p8 = digits
                .Where(d => d.Length > 1 && d[1] == 'i')
                .Reverse();
            foreach (var d in p8)
                Console.WriteLine(d);
            Console.WriteLine();
            #endregion
            #endregion*/
            /*#region LINQ - Transformation Operators
             #region Problem1
                Console.WriteLine("Product Names:");
                var trans1 = products.Select(p => p.ProductName);
                foreach (var name in trans1)
                    Console.WriteLine(name);
                Console.WriteLine();
                #endregion
             #region Problem2
                Console.WriteLine("Upper/Lower Case Words:");
                string[] words2 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
                var trans2 = words2.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
                foreach (var w in trans2)
                    Console.WriteLine($"Upper: {w.Upper}, Lower: {w.Lower}");
                Console.WriteLine();
                #endregion
             #region Problem3
                Console.WriteLine("Product Properties (Rename UnitPrice to Price):");
                var trans3 = products.Select(p => new { p.ProductName, Price = p.UnitPrice });
                foreach (var p in trans3)
                    Console.WriteLine(p);
                Console.WriteLine();
              #endregion
             #region Problem4
                Console.WriteLine("Number matches position in array:");
                int[] ArrTrans4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var trans4 = ArrTrans4.Select((num, index) => new { Number = num, InPlace = num == index });
                Console.WriteLine("Number: In-place?");
                foreach (var item in trans4)
                    Console.WriteLine($"{item.Number}: {item.InPlace}");
                Console.WriteLine();
                #endregion
             #region Problem5
                Console.WriteLine("Pairs where a < b:");
                int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
                int[] numbersB = { 1, 3, 5, 7, 8 };
                var trans5 = from a in numbersA
                             from b in numbersB
                             where a < b
                             select new { A = a, B = b };
                Console.WriteLine("Pairs where a < b:");
                foreach (var pair in trans5)
                    Console.WriteLine($"{pair.A} is less than {pair.B}");
                Console.WriteLine();
                #endregion
             #region Problem6
                Console.WriteLine("Orders total < 500.00:");
                var trans6 = customers.SelectMany(c => c.Orders).Where(o => o.Total < 500.00);
                foreach (var order in trans6)
                    Console.WriteLine($"Order ID: {order.Id}, Total: {order.Total}");
                Console.WriteLine();
                #endregion
             #region Problem7
                Console.WriteLine("Orders made in 1998 or later:");
                var trans7 = customers.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
                foreach (var order in trans7)
                    Console.WriteLine($"Order ID: {order.Id}, Date: {order.OrderDate.ToShortDateString()}");
                Console.WriteLine();
                #endregion
            #endregion*/
            /*#region LINQ - Aggregate Operators

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            string[] words = File.Exists("dictionary_english.txt")
            ? File.ReadAllLines("dictionary_english.txt")
            : new string[] { "apple", "banana", "computer", "science", "linq" };

            #region Problem1
            Console.WriteLine("Count Odd Numbers:");
            Console.WriteLine(Arr.Count(n => n % 2 != 0));
            Console.WriteLine();
            #endregion

            #region Problem2
            Console.WriteLine("Customers Orders Count:");
            var p2 = customers
                .Select(c => new { c.Name, OrdersCount = c.Orders.Length });

            foreach (var c in p2)
                Console.WriteLine($"{c.Name} => {c.OrdersCount}");
            Console.WriteLine();
            #endregion

            #region Problem3
            Console.WriteLine("Categories Products Count:");
            var p3 = products
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, Count = g.Count() });

            foreach (var g in p3)
                Console.WriteLine($"{g.Category} => {g.Count}");
            Console.WriteLine();
            #endregion

            #region Problem4
            Console.WriteLine("Sum Of Numbers:");
            Console.WriteLine(Arr.Sum());
            Console.WriteLine();
            #endregion

            #region Problem5
            Console.WriteLine("Total Characters In Dictionary:");
            Console.WriteLine(words.Sum(w => w.Length));
            Console.WriteLine();
            #endregion

            #region Problem6
            Console.WriteLine("Total Units In Stock Per Category:");
            var p6 = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    TotalUnits = g.Sum(p => p.UnitsInStock)
                });

            foreach (var g in p6)
                Console.WriteLine($"{g.Category} => {g.TotalUnits}");
            Console.WriteLine();
            #endregion

            #region Problem7
            Console.WriteLine("Shortest Word Length:");
            Console.WriteLine(words.Min(w => w.Length));
            Console.WriteLine();
            #endregion

            #region Problem8
            Console.WriteLine("Cheapest Price Per Category:");
            var p8 = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    CheapestPrice = g.Min(p => p.UnitPrice)
                });

            foreach (var g in p8)
                Console.WriteLine($"{g.Category} => {g.CheapestPrice}");
            Console.WriteLine();
            #endregion

            #region Problem9
            Console.WriteLine("Cheapest Products Per Category:");

            var p9 =
                from p in products
                group p by p.Category into g
                let minPrice = g.Min(x => x.UnitPrice)
                select new
                {
                    Category = g.Key,
                    Products = g.Where(x => x.UnitPrice == minPrice)
                };

            foreach (var g in p9)
            {
                Console.WriteLine(g.Category);
                foreach (var p in g.Products)
                    Console.WriteLine($"  {p.ProductName} - {p.UnitPrice}");
            }
            Console.WriteLine();
            #endregion

            #region Problem10
            Console.WriteLine("Longest Word Length:");
            Console.WriteLine(words.Max(w => w.Length));
            Console.WriteLine();
            #endregion

            #region Problem11
            Console.WriteLine("Most Expensive Price Per Category:");
            var p11 = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    MaxPrice = g.Max(p => p.UnitPrice)
                });

            foreach (var g in p11)
                Console.WriteLine($"{g.Category} => {g.MaxPrice}");
            Console.WriteLine();
            #endregion

            #region Problem12
            Console.WriteLine("Most Expensive Products Per Category:");

            var p12 =
                from p in products
                group p by p.Category into g
                let maxPrice = g.Max(x => x.UnitPrice)
                select new
                {
                    Category = g.Key,
                    Products = g.Where(x => x.UnitPrice == maxPrice)
                };

            foreach (var g in p12)
            {
                Console.WriteLine(g.Category);
                foreach (var p in g.Products)
                    Console.WriteLine($"  {p.ProductName} - {p.UnitPrice}");
            }
            Console.WriteLine();
            #endregion

            #region Problem13
            Console.WriteLine("Average Word Length:");
            Console.WriteLine(words.Average(w => w.Length));
            Console.WriteLine();
            #endregion

            #region Problem14
            Console.WriteLine("Average Price Per Category:");
            var p14 = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AvgPrice = g.Average(p => p.UnitPrice)
                });

            foreach (var g in p14)
                Console.WriteLine($"{g.Category} => {g.AvgPrice}");
            Console.WriteLine();
            #endregion

            #endregion*/
            /*#region LINQ – Partitioning Operators

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Problem1
            Console.WriteLine("First 3 Orders From Washington:");

            var p1 = customers
                .Where(c => c.City == "Washington")
                .SelectMany(c => c.Orders)
                .Take(3);

            foreach (var order in p1)
                Console.WriteLine(order);
            Console.WriteLine();
            #endregion

            #region Problem2
            Console.WriteLine("Skip First 2 Orders From Washington:");

            var p2 = customers
                .Where(c => c.City == "Washington")
                .SelectMany(c => c.Orders)
                .Skip(2);

            foreach (var order in p2)
                Console.WriteLine(order);
            Console.WriteLine();
            #endregion

            #region Problem3
            Console.WriteLine("Take While Number >= Index:");

            var p3 = numbers
                .TakeWhile((num, index) => num >= index);

            foreach (var n in p3)
                Console.WriteLine(n);
            Console.WriteLine();
            #endregion

            #region Problem4
            Console.WriteLine("Skip Until First Divisible By 3:");

            var p4 = numbers
                .SkipWhile(n => n % 3 != 0);

            foreach (var n in p4)
                Console.WriteLine(n);
            Console.WriteLine();
            #endregion

            #region Problem5
            Console.WriteLine("Skip Until Number < Index:");

            var p5 = numbers
                .SkipWhile((num, index) => num >= index);

            foreach (var n in p5)
                Console.WriteLine(n);
            Console.WriteLine();
            #endregion

            #endregion*/
            /*#region LINQ - Quantifiers

            string[] words = File.Exists("dictionary_english.txt")
            ? File.ReadAllLines("dictionary_english.txt")
            : new string[] { "apple", "receive", "science", "height", "friend" };

            #region Problem1
            Console.WriteLine("Any word contains 'ei'?");

            bool q1 = words.Any(w => w.Contains("ei"));

            Console.WriteLine(q1);
            Console.WriteLine();
            #endregion


            #region Problem2
            Console.WriteLine("Categories With At Least One Out Of Stock Product:");

            var q2 = products
                .GroupBy(p => p.Category)
                .Where(g => g.Any(p => p.UnitsInStock == 0));

            foreach (var group in q2)
            {
                Console.WriteLine(group.Key);
                foreach (var product in group)
                    Console.WriteLine($"  {product.ProductName} - Stock: {product.UnitsInStock}");
            }
            Console.WriteLine();
            #endregion


            #region Problem3
            Console.WriteLine("Categories Where All Products Are In Stock:");

            var q3 = products
                .GroupBy(p => p.Category)
                .Where(g => g.All(p => p.UnitsInStock > 0));

            foreach (var group in q3)
            {
                Console.WriteLine(group.Key);
                foreach (var product in group)
                    Console.WriteLine($"  {product.ProductName} - Stock: {product.UnitsInStock}");
            }
            Console.WriteLine();
            #endregion

            #endregion*/
        }
    }
}