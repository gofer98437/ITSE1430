using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasPena.MovieLib.Host
{
    class Program
    {
        static void Main( string[] args )
        {
            int choice = 0;
            bool mainMenu = false;
            string filmTitle = "None";

            List<string> filmList = new List<string>{"None"};

            Console.WriteLine("\nPlease enter the name of the Film: ");
            filmTitle = Console.ReadLine();
            Console.WriteLine("Title: ", filmTitle);

            mainMenu = true;                                        //temp

            while (mainMenu == true)
            {

                Console.WriteLine("Main Menu/n/n" +
                    "1) Add a film to the collection./n " +
                    "2) Remove a film from the collection." +
                    "3) View all films in the collection./n" +
                    "4) Exit");

                choice = Console.Read();

                switch (choice)
                {
/*
Console applications typically have a menu to allow the user to interact with the system. Our application will allow the following options.

List the movies
Add a new movie
Remove an existing movie
Exit the application
Create a menu to display the available options. 
Until the user selects the option to exit, keep displaying the menu and performing the requested action.
*/
                    case 1:
                        {
                            foreach(string f in filmList)
                            {
                                Console.WriteLine("/nJust testing/n");
                                
                            }
                            break;
                        }
                    
                    case 2:
                        {
                            break;
                        }
                    default:
                    break;
                }


            }
        }
    }
}