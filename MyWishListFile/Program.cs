using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Gebruiker\samples\wishlist";
            string fileName = @"\\myWishList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");

            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActice = true;

            while (loopActice)
            {
                Console.WriteLine("Would you like to add a wish? Y or N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActice = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Your wish: {wish}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
        }
    }
}
