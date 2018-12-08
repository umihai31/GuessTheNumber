using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {

        //This method is verifying if the string can be converted to an integer. If everything it's ok , the good number is returned 
        public static int VerifyNumber(string numbr)
        {
            bool result = Int32.TryParse(numbr, out int nr); // first try to convert the number to int 

            while (!result) // if the user has provided a wrong character than int , the program will tell him to give us a good number
            {

                Console.WriteLine("{0} is not a number , please provide another number:", numbr);
                numbr = Console.ReadLine();
                result = Int32.TryParse(numbr, out nr);

            }

            return nr;
        }

        
        static void Main(string[] args)
        {

            //Generate random number 

            Random rng = new Random();
            int r = rng.Next(1, 100);
            Console.WriteLine("Our random number is {0}", r);

            Console.WriteLine("Guess the number !!!");
            Console.WriteLine("Choose a number between 0 and 100");

            int attempt = 0; // attempt is a score feature 
            string number = Console.ReadLine();// number to read from keyboard
            attempt += 1; 
            
            // if the value is less than 0 and higher than 100 ,the program will tell him to give us a good number
            int nrr = VerifyNumber(number);       
          
            //Loop for verifing if the number is different than the number given by the operator 
            while (nrr != r)
            {
                while (nrr < 0 || nrr > 100)
                {
                    Console.WriteLine("Please give us another number (Out of range)");
                    number = Console.ReadLine();
                    nrr = VerifyNumber(number);
                }

                Console.WriteLine("Your wrote the number : {0}", nrr);// show on the console the number

                if (nrr < r)// number lower ?
                {
                    Console.WriteLine("Your number is lower than our random.Please provide another number");
                    //Overwrite the number 
                    number = Console.ReadLine();          
                    nrr = VerifyNumber(number);
                    attempt = attempt + 1;

                }

                else //Number higher ?
                {
                    Console.WriteLine("Your number is higher than our random.Please provide another number");
                    //Overwrite the number 
                    number = Console.ReadLine();
                    nrr = VerifyNumber(number);
                    attempt = attempt + 1;
                }
            }

                //If the number is equal to our number finish the program 
            if (nrr == r)
           {
                if (attempt == 1) // HIGHSCOREEEEEEE
                {
                    Console.WriteLine("OMG !!! HIGHSCORE !!!!!!!!");
                    Console.WriteLine("You made {0} attempt!!!!", attempt);
                    Console.ReadLine();// This is for keeping console open
                }
                else
                {
                    Console.WriteLine("Congrats , you WINNNNN!!!!");
                    Console.WriteLine("You made {0} attempts", attempt);
                    Console.ReadLine(); // This is for keeping console open
                }
            }

        }
    }

}


