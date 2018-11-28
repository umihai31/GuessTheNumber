using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number !!!");
            Console.WriteLine("Choose a number between 0 and 100");
            string numbr = Console.ReadLine();
            bool result = Int32.TryParse(numbr,out int nr);
            while (!result)
            {
                
                    Console.WriteLine("{0} is not a number , please provide another number:",numbr);
                    numbr = Console.ReadLine();
                    result = Int32.TryParse(numbr, out nr);

            }

            while (nr < 0 || nr > 100)
            {
                Console.WriteLine("Please give us another number");
                numbr = Console.ReadLine();
                result = Int32.TryParse(numbr, out nr);
            }

           // nr = int.Parse(numbr);
            Console.WriteLine("Your wrote th number : {0}", nr);
            //Generate random number 

            Random rng = new Random();
            int r = rng.Next(1, 100);

            //Loop for verifing if the number is different than the number given by the operator 
            while (nr != r)
            {
                if (nr < r)
                {
                    Console.WriteLine("Your number is lower than our random");
                    //Overwrite the number 
                    numbr = Console.ReadLine();
                    nr = int.Parse(numbr);

                }

                else
                {
                    Console.WriteLine("Your number is higher than our random");
                    //Overwrite the number 
                    numbr = Console.ReadLine();
                    nr = int.Parse(numbr);
                }

                //If the number is equal to our number finish the program 
                if (nr == r)
                {
                    Console.WriteLine("Congrats , you WINNNNN!!!!");
                }
              
            }
        }
    }
}
