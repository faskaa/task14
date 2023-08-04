using System.Diagnostics.Tracing;
using System.Globalization;
using System.Net.Security;

namespace newTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Toyota"};


            //int i = 0 ;

            //while (i < cars.Length)
            //{
            //    if (cars[i] == "o")
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }

            //    i++;




            //}

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Toyota" };
            //int count = 0;

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    for (int j = 0; j < cars[i].Length; j++)
            //    {
            //        if (cars[i][j] == 'o') 
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //string Word = "Bahramov Fazil";
            //char a = 'i';
            //int count = 0;

            //for (int i = 0; i < Word.Length; i++)
            //{
            //    if (Word[i] == a)
            //    {

            //        count++;


            //    }


            //}
            //Console.WriteLine("You have " + count + " character");

            string palindrome = "azza";

            int j = 0;

            for (int i = palindrome.Length; i < palindrome.Length/2 ; i++)
            {
                j--;
                if (palindrome[i] = palindrome[j] ) { }
            }

        }
    }
}