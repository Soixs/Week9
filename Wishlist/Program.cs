using System;
using System.Collections.Generic;

namespace Wishlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("hot chocolate machine");
            myWishList.Add("new bicycle");
            myWishList.Add("new pair of socks");
            myWishList.Add("new pair of sneakers");

            Console.WriteLine(myWishList.Count);

            //Console.WriteLine(myWishList[0]);
            //Console.WriteLine(myWishList[1]);
            //Console.WriteLine(myWishList[2]);
            // saab nii, aga järgnevalt lihtsam, kuna ei pea teadma, palju variante on sees

            foreach (string wish in myWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
