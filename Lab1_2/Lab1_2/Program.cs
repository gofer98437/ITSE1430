﻿// Chas Pena
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
        static void Main( string[] args )
        {
            bool quit = false;
            while (!quit)
            {
                int choice = DisplayMenu();

                switch (choice)
                {
                    case '1':
                    AddFilm();
                    break;
                    case '2':
                    RemoveFilm();
                    break;
                    case '3':
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
            _name = ReadString("Enter name: ", true);

            _length = ReadDecimal("Enter price: ", 0);

            _description = ReadString("Enter optional description: ", false);

            _owned = ReadBool("Do you own this film (Y/N): ");
        }

        private static void RemoveFilm()
        {
            _name = "";

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
                    string msg = String.Format("Value must be >= {0}" + minValue);
                    Console.WriteLine("Value must be >= {0}" + minValue);

                }else if (result >= minValue)
                    return result;

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

        private static bool ReadBool( string v )
        {
            throw new NotImplementedException();
        }

        static void ListFilms()
        {
            if (_name != null && _name != "")
                if (!String.IsNullOrEmpty(_name))
                {


                    //var msg = String.Format("{0} [${1}]", _name, _price);
                    string msg = $"{_name} [${_length}]";
                    Console.WriteLine(msg);


                    if (!String.IsNullOrEmpty(_description))
                        Console.WriteLine(_description);
                } else
                    Console.WriteLine("No Films");
        }

        static string _name;
        static decimal _length;
        static string _description;
        static bool _owned;


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
