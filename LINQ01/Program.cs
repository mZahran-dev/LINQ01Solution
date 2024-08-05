using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static LINQ01.ListGenerator;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region 1.Find all products that are out of stock.
            //var products = ProductsList.Where(P => P.UnitsInStock == 0);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 2.Find all products that are in stock and cost more than 3.00 per unit.
            //var products = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 3.Returns digits whose name is shorter than their value.
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var shorterNameDigits = arr.Where((name,index) => name.Length < index).ToList();
            //foreach (var digit in shorterNameDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #endregion

            #region Part 02

            #region 1.Sort a list of products by name
            //var products = ProductsList.OrderBy(P => P.ProductName);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region 2.Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //// we can make a class that implement the IComparer interface
            //string[] sortedArr = SortArrayCaseInsensitive(Arr);
            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3.Sort a list of products by units in stock from highest to lowest.
            //var products = ProductsList.OrderByDescending(P => P.UnitsInStock);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var SortedList = Arr.OrderBy(x => x.Length).ThenBy(N => N);
            //foreach (var sortedList in SortedList)
            //{
            //    Console.WriteLine(sortedList);
            //}


            #endregion

            #region 5.Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = SortWordsByLengthAndCaseInsensitive(words);
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var products = ProductsList.OrderByDescending(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region 7.Sort first by word length and then by a case -insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArray = SortWordsByLengthAndCaseInsensitiveDescending(Arr);
            //foreach (string str in sortedArray)
            //{
            //    Console.WriteLine(str);
            //} 

            #endregion

            #region 8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var filterdArray = Arr.Where(a => a.Length > 1 && a[1] == 'i').Reverse();
            foreach (var digit in filterdArray)
            {
                Console.WriteLine(digit);
            }
            #endregion

            #endregion
        }
    }
}
