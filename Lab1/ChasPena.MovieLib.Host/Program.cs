using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ChasPena.MovieLib.Host
//{
//    class Program
//    {
//        static void Main( string[] args )
//        {
//            int choice = 0;
//            bool mainMenu = false;
//            string filmTitle = "None";

//            List<string> filmList = new List<string>{"None"};

//            Console.WriteLine("\nPlease enter the name of the Film: ");
//            filmTitle = Console.ReadLine();
//            Console.WriteLine("Title: ", filmTitle);

//            mainMenu = true;                                        //temp

//            while (mainMenu == true)
//            {

//                Console.WriteLine("Main Menu/n/n" +
//                    "1) Add a film to the collection./n " +
//                    "2) Remove a film from the collection." +
//                    "3) View all films in the collection./n" +
//                    "4) Exit");

//                choice = Console.Read();

//                switch (choice)
//                {
///*
//Console applications typically have a menu to allow the user to interact with the system. Our application will allow the following options.

//List the movies
//Add a new movie
//Remove an existing movie
//Exit the application
//Create a menu to display the available options. 
//Until the user selects the option to exit, keep displaying the menu and performing the requested action.
//*/
//                    case 1:
//                        {
//                            foreach(string f in filmList)
//                            {
//                                Console.WriteLine("/nJust testing/n");
                                
//                            }
//                            break;
//                        }
                    
//                    case 2:
//                        {
//                            break;
//                        }
//                    default:
//                    break;
//                }
                 

//            }
//        }
//    }
//}



//============================================================================================================



namespace Nile.Host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while (!quit)
            {
                int choice = DisplayMenu();

                switch (choice)
                {
                    case '1':
                    ListFilms();
                    break;
                    case '2':
                    AddFilm();
                    break;
                    case '3':
                    quit = true;
                    break;
                };
            };
        }

        static void AddFilm()
        {
            _name = ReadString("Enter name: ", true);

            _price = ReadDecimal("Enter price: ", 0);

            _description = ReadString("Enter optional description", false);
        }


        private static decimal ReadDecimal( string message, decimal minValue )
        {
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();

                if (Decimal.TryParse(value, out decimal result))
                {
                    if (result >= minValue)
                        return result;

                }

                string msg = String.Format("Value must be >= {0}" + minValue);
                Console.WriteLine("Value must be >= {0}" + minValue);
            } while (true);
        }


        private static string ReadString( string message, bool isRequired )
        {
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();
                if (!isRequired || value != "")
                    return value;

                Console.WriteLine("Value is Required");
            } while (true);
        }

        static void ListFilms()
        {
            if (_name != null && _name != "")
                if (!String.IsNullOrEmpty(_name))
                {


                    //var msg = String.Format("{0} [${1}]", _name, _price);
                    string msg = $"{_name} [${_price}]";
                    Console.WriteLine(msg);


                    if (!String.IsNullOrEmpty(_description))
                        Console.WriteLine(_description);
                } else
                    Console.WriteLine("No Films");
        }

        static string _name;
        static decimal _price;
        static string _description;


        private static char DisplayMenu()
        {
            do
            {

                Console.WriteLine("Main Menu");
                Console.WriteLine("1) Add a film to the collection.");
                Console.WriteLine("2) Remove a film from the collection.");
                Console.WriteLine("3) View all films in the collection.");
                Console.WriteLine("4) Exit");

                string choice = Console.ReadLine();
                
                //choice = choice.Trim();

                //input = input.PadLeft(10)

                //input.StartsWith(@"\");
                //input.EndsWith(@"\");

                //input.ToLower();

                if (choice[0] == '1')
                    return choice[0];
                else if (choice[0] == '2')
                    return choice[0];
                else if (choice[0] == '3')
                    return choice[0];
                else if (choice[0] == '4')
                    return choice[0];


                Console.Write("\nPlease choose a valid option");

            } while (true);
        }
    }
}
































//        static void PlayingWithPrimitives()
//        {
//            decimal unitPrice = 10.5m;

//            real declaration
//            System.Decimal unitPrice2 = 10.5m;

//            current time
//            System.DateTime now = DateTime.Now;

//            ArrayList items;

//        }

//        static void PlayingWithVariables()
//        {

//            int hours = 8;
//            double rate = 35.7;

//            int hours2 = hours;

//            string firstName, lastName;

//            rate = 50;

//            firstName = "dogcat";

//            firstName = lastName = "what thats no name!";

//            double ceiling = Math.Ceiling(rate);
//            double floor = ceiling;

//        }

//    }
//}

