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
            int attempt = 0; 
            string numbr = Console.ReadLine();// number to read from keyboard
            bool result = Int32.TryParse(numbr,out int nr); // first try to convert the number to int 
            while (!result) // if the user has provided a wrong character than int , the program will tell him to give us a good number
            {
                
                    Console.WriteLine("{0} is not a number , please provide another number:",numbr);
                    numbr = Console.ReadLine();
                    result = Int32.TryParse(numbr, out nr);

            }

            // if the value is less than 0 and higher than 100 ,the program will tell him to give us a good number
                while (nr < 0 || nr > 100) { 
                Console.WriteLine("Please give us another number");
                numbr = Console.ReadLine();
                result = Int32.TryParse(numbr, out nr);
            }

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
                    attempt = attempt + 1;

                }

                else
                {
                    Console.WriteLine("Your number is higher than our random");
                    //Overwrite the number 
                    numbr = Console.ReadLine();
                    nr = int.Parse(numbr);
                    attempt = attempt + 1;
                }

                //If the number is equal to our number finish the program 
                if (nr == r)
                {
                    Console.WriteLine("Congrats , you WINNNNN!!!!");
                    Console.WriteLine("You made {0} attempts", attempt);
                }
              
            }
        }
    }
}
