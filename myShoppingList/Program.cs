using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Gebruiker\samples\Shopinglist";
            string fileName = @"\\myShoppingLists.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");

            List<string> myShoppingLists = arrayFromFile.ToList<string>();

            bool loopActice = true;

            while (loopActice)
            {
                Console.WriteLine("Would you like to add a item to your shopping list? Y or N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string userItem = Console.ReadLine();
                    myShoppingLists.Add(userItem);
                }
                else
                {
                    loopActice = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string item in myShoppingLists)
            {
                Console.WriteLine($"Your item: {item}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingLists);
        }
        
    }
}
