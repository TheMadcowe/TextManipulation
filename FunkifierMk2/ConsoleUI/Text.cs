using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Text
    {

        public string InputText { get; set; }
        public string Password { get; set; }


        public string Manipulator(string operation)
        {
            string output = "";
            string inputText = InputText.ToUpper();

            switch(operation)
            {
                case ("U"):
                    output = inputText;
                    break;
                case ("L"):
                    output = inputText.ToLower();
                    break;
                case ("C"):
                    output = Funkify(inputText);
                    break;
                case ("P"):
                    output = Codify(InputText);
                    break;
                default:
                    output = "You had 1 job and you still blew it, congrats.";
                    break;

               
            }
            return output;

        }

        public string Funkify(string text)
        {
            string output = "";
            for(int i = 0; i < text.Length; i++)
            {
                if(i % 2 == 0)
                {
                    output += text.Substring(i, 1).ToLower();
                }
                else
                {
                    output += text.Substring(i, 1).ToUpper();
                }
            }
            return output;
        }

        public string Codify (string text)
        {
            string output = "";
            var passText = text.ToCharArray();
            var pass = Password.ToCharArray();
            int passValue = 0;

            for( int i = 0; i < pass.Length; i++)
            {
                passValue += (int)pass[i];
            }

            
            for(int i = 0; i < text.Length; i++)
            {

                output += (char)(passText[i] + passValue);
                Console.WriteLine($"Char: { passText[i] + passValue }");
            }

            return output;
        }
  
    }
}

