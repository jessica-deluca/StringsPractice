using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Daniel";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);

            //string myFaveQuote = "\"It's a yam sham\" - Buffy Summers"; //escape characters
            //Console.WriteLine(myFaveQuote);

            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine \nHi"; //escape characters: \t (tab), \n (new line)
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a"; //escape characters: \\ (use backslash), \a (make noise)

            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //Console.WriteLine("User one, please type something.");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something.");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput.Equals(userTwoInput)) // userOneInput is an object, .Equals is a method
            //{
            //    Console.WriteLine("User two is a copycat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}

            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Mike.";
            //string fullSentence = string.Concat(startOfSentence, endOfSentence);

            //Console.WriteLine(fullSentence);

            //Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence); // {0} finds what's after comma and puts it there
            //Console.WriteLine("The first part of my sentence was {0}, the second was {1}, and the third was {2}", startOfSentence, endOfSentence, fullSentence);

            //Console.WriteLine("This is a tab \t. \nThis is a backspace \\. \nThis is a bell sound. \a");

            // EXTENSION: Get user input for the first and last name instead of hardcoding, such as string fName = "Mary";

            //Console.WriteLine("Enter your first name.");
            //string firstName = Console.ReadLine();

            //int lengthOfFirstName = firstName.Length;

            //Console.WriteLine("Enter your last name.");
            //string lastName = Console.ReadLine();

            //int lengthOfLastName = lastName.Length;

            //Console.WriteLine(lengthOfLastName);

            //if (lengthOfFirstName > lengthOfLastName)
            //{
            //    Console.WriteLine("First is longer."); //If the first name is longer than the last name, print "First is longer."
            //}
            //else if (lengthOfFirstName == lengthOfLastName)
            //{
            //    Console.WriteLine("Samsis!"); //If the first name and last name are the same length, print "Samsis!"
            //}
            //else
            //{
            //    Console.WriteLine("Last must be longer!"); //Otherwise, print "last must be longer!"
            //}

            //if (userOneInput.Equals(userTwoInput)) // userOneInput is an object, .Equals is a method
            //{
            //    Console.WriteLine("User two is a copycat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}

            // Comparing Strings for Equality *First try the following using == and then try it using .Equals()
            // Create a variable and assign a person's first name to it.
            // Create a variable and assign a different person's first name to it.
            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            //string firstPersonName = "Jessica";
            //string secondPersonName = "Paige";

            ////if (firstPersonName == secondPersonName)
            ////{
            ////    Console.WriteLine("The names are the same.");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("The names are different.");
            ////}

            //if (firstPersonName.Equals(secondPersonName))
            //{
            //    Console.WriteLine("User two is a copycat!");
            //}
            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}

            ////Console.WriteLine("Enter your first name.");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("Enter your last name.");
            //string lastName = Console.ReadLine();

            //Console.WriteLine(firstName + " " + lastName); //using +, print user's full name including a space to separate the names

            ////string fullName = string.Concat(firstName, " ", lastName); //using .Concat(), print user's full name including a space to separate the names
            ////Console.WriteLine(fullName);

            Console.WriteLine("Guess what type of pet I have. (Hint: It's the opposite of a dog.)");
            string answer = Console.ReadLine();

            string lower = answer.ToLower(); // converts user's answer to all lowercase so that if they enter cat or CAT, either answer will be correct

            switch (lower)
            {
                case "cat": // "cat" is case senstive so we need to convert answer to all lowercase as shown above
                    Console.WriteLine("You guessed correctly!");
                    break;
                default:
                    Console.WriteLine("You guess incorrectly!");
                    break;
            }


        }
    }
}
