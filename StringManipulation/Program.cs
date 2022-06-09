using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define new variables
           
            string name;
            string firstname;
            string surename;
            char characterSearch;
            int characterPosition;

            //get name from console
            Console.WriteLine("Enter a string here: ");
            name = Console.ReadLine();

            //get character to search from console
            Console.WriteLine("Enter a character to search: ");
            characterSearch = Console.ReadLine()[0];

            //get character position
            characterPosition = name.IndexOf(characterSearch);

            //write result to console
            Console.WriteLine("The position of the character is {0}", characterPosition);

            //get firstname and suranme from console
            Console.WriteLine("Enter a firstanme here: ");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter a surename here: ");
            surename = Console.ReadLine();

            string fullname = string.Concat(firstname," ",surename);
            Console.WriteLine("Fulname: {0}", fullname);


            Console.ReadKey();
        }
    }
}
