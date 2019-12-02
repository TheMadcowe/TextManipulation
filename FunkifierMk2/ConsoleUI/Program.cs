using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StartWorking();
        }

        static void StartWorking()
        {
            Console.WriteLine("Hello and welcome!\n\nPlease enter the text you'd like to manipulate.\n");

            var text = new Text();
            var operation = "";


            text.InputText = Console.ReadLine();

            Console.WriteLine("\nWhat would you like to do with it?\n\nMAKE UPPERCASE? (U)\nmake lower case? (L)\npErHaPs MaKe It AlL cRaZy? (C)\n" +
                "Or maybe... just maybe... you want to encode it with a Password? (P)");

            operation = Console.ReadLine().ToUpper();

            if( operation == "P")
            {
                Console.Write("Please enter your Password: ");

                text.Password = Console.ReadLine();
            }

            Console.WriteLine($"Here you go!\n{ text.Manipulator(operation) }\n\nWould you like to go again? (Y/N)");

            string again = Console.ReadLine().ToUpper();

            if(again == "Y")
            {
                StartWorking();
            }

        }


        
    }
}
