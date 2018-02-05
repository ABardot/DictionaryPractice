using System;
using System.Collections.Generic;

namespace DictionaryPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Syntax Dictionary <Key data type, value data type> dictionary
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                { "Kerry", 90 }, // "Kerry" is the key , 90 is the value
                { "Barry", 85 },
                { "Michelle", 100 }
            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch kids" },
                { "A4", "Funyuns"}
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>(); // Set up with no values, this is set up to take values

            // Using the Add() method, lets add drinks to our drink machine. 
            // This machine uses just a number to vend as item instead of a letter number
            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Barq's Root Beer");
            drinkMachine.Add(13, "Diet Coke");
            drinkMachine.Add(14, "Sprite");
            drinkMachine.Add(15, "Sparkling Water");



            Console.WriteLine(drinkMachine.Count); // Count is a property that returns the size of the dictionary 
        }
    }
}