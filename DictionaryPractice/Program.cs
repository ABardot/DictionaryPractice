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

            // We have another property, called, Key
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            //// Create a dictionary for a theater coat check, the key will be a number and the value the coat style. Print all values
            //Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            //{
            //    {1, "Winter jacket" },
            //    {2, "Summer jacket" },
            //    {3, "Autmun Jacket" },
            //    {4, "Spring Jacket"},
            //    {5, "Ski Jacket" },
            //    {6, "Ski Jacket" },
            //    {7, "Hunting jacket" },
            //    {8, "Motorcycle jacket" },
            //    {9, "Camo Jacket" },
            //    {10, "black Jacket" }
            //};

            //foreach (KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat.Key);
            //}
            //Create a dictionary for a car valet service with ten cars, the key will be the customers last name and the value
            //will be the car make. Print to console
            //Dictionary<string, string> carValet = new Dictionary<string, string>()
            //{
            //    {"Smith" , "BMW" },
            //    {"Sam" , "Ford" },
            //    {"Bond", "Austin Martin" },
            //    {"Sanders", "Toyota"},
            //    {"Thomas", "Mercedes Benz" },
            //    {"Trump", "Limo" },
            //    {"Bardot", "Audi" },
            //    {"Clinton", "Nissan" },
            //    {"Clinton", "Nissan" },
            //    {"Brady", "Ferrari" }
            //};
            //foreach (KeyValuePair<string, string> car in carValet)
            //{
            //    Console.WriteLine(car.Key);
            //}

            Dictionary<string, int> zooAnimal = new Dictionary<string, int>()
            {
                {"Pig",10  },
                {"Zebra",22 },
                {"Horse",36 },
                {"Elephant", 42},
                {"Shark",65},
                {"Bear", 68},
                {"Snake", 77},
                {"Beatles", 89},
                {"Monkey", 99},
                { "Giraffe", 10}
            };

            int highest = 0;
            foreach (KeyValuePair<string, int> animal in zooAnimal)
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }

            foreach (KeyValuePair<string, int> animal in zooAnimal)
            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }

        // Remove the zoo animal with the lowest quantity from the dictionary using the Remove method.
        // Use the Count property to count the number of remaining entries in the dictionary. Print to the console.
        // Create a program that allows a user to input an animal name to check to see if the dictionary contains that animal name.
        // If the animal does not exist in the dictionary, ask the user if he / she would like to add it.If so, add the animal to the dictionary.


        }
    }
}