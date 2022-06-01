using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace YourOrderPlease
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Order("is2 Thi1s T4est 3a"));
        }
        public static string Order(string words)
        {
            if (words == String.Empty)
            {
                return "";
            }
            Regex rg = new Regex(@"\d+");
            
            var wordsList = words.Split(' ').ToList();
          
            var numbersList = wordsList
                .Select(word => Int32.Parse(rg.Match(word).Value)).ToList();
            
            numbersList.Sort();
            
            var resultList = numbersList
                .Select(number => wordsList
                    .First(word => word
                        .Contains(number.ToString())))
                    .ToList();
            
            return String.Join(" ",resultList);

        }
    }
}