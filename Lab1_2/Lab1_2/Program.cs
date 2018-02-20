// Chas Pena
// Lab1_redo
// Michael Taylor
// 2/11/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Host
{
    class Program
    {
        static string _title;
        static decimal _length;
        static string _description;
        static bool _owned;

        static void Main( string[] args )
        {
            bool quit = false;
            while (!quit)
            {
                Console.Clear();

                int choice = DisplayMenu();

                switch (choice)
                {
                    case '1':
                    Console.Clear();
                    AddFilm();
                    break;
                    case '2':
                    Console.Clear();
                    RemoveFilm();
                    break;
                    case '3':
                    Console.Clear();
                    ListFilms();
                    break;
                    case '4':
                    quit = true;
                    break;
                };
            };
        }

        static void AddFilm()
        {
            _title = ReadString("Enter the title of the film: ", true);

            _length = ReadDecimal("Enter the length in hours: ", 0);

            _description = ReadString("Enter description: ", false);

            _owned = ReadBool("Do you own this film (Y/N): ", true);
        }

        private static void RemoveFilm()
        {
            _title = "";

            _length = 0;

            _description = "";

            _owned = false;
        }

        private static decimal ReadDecimal( string message, decimal minValue )
        {
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();

                if (!Decimal.TryParse(value, out decimal result))
                {
                    Console.WriteLine($"\nValue must be >= {minValue}");
                    continue;
                }

                if (result >= minValue)
                    return result;

            } while (true);
        }

        private static string ReadString( string message, bool isRequired )
        {
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();

                if (isRequired || !String.IsNullOrEmpty(value))
                {
                    return value;
                } else
                    Console.WriteLine("\nA value is Required");
                continue;

            } while (true);
        }

        private static bool ReadBool( string message, bool isRequired )
        {
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();

                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("\nPlease choose a valid option.");
                    Console.Read();
                    //Console.Clear();
                    continue;
                }

                value = value.ToLower();

                if (value[0] == 'y')
                    return true;
                else if (value[0] == 'n')
                    return false;


            } while (true);
        }

        static void ListFilms()
        {
            if (!String.IsNullOrEmpty(_title))// ?? "";
            {
                string msg = $"{_title}: {_length} hours";
                Console.WriteLine(msg);

                if (!String.IsNullOrEmpty(_description))
                    Console.WriteLine(_description);
            } else
                Console.WriteLine("No Films");
            Console.ReadLine();
            //Console.Clear();
        }

        private static char DisplayMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1) Add a film to the collection.");
                Console.WriteLine("2) Remove a film from the collection.");
                Console.WriteLine("3) View all films in the collection.");
                Console.WriteLine("4) Exit");

                string choice = Console.ReadLine();

                if (String.IsNullOrEmpty(choice))
                {
                    Console.Write("\nPlease choose____ a valid option");

                    continue;
                }

                if (choice[0] == '1')
                    return choice[0];
                else if (choice[0] == '2')
                    return choice[0];
                else if (choice[0] == '3')
                    return choice[0];
                else if (choice[0] == '4')
                    return choice[0];

            } while (true);
        }
    }
}
