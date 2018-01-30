using System;
using System.Collections;

namespace Nile.Host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while(!quit)
            {
                //display
                char choice = DisplayMenu();

                //process
                switch (choice)
                {
                    case 'L': ListProducts();
                    break;
                    case 'A': AddProduct();
                    break;
                    case 'Q': quit = true;
                    break;
                };
            };
        }

        static void AddProduct()
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

                if(Decimal.TryParse(value, out decimal result));
                {
                    if (result >= minValue)
                        return result;

                }


                Console.WriteLine("Value must be >= {0}" + minValue);
            } while (true);
        }


        private static string ReadString(string message, bool isRequired)
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

        static void ListProducts()
        {
            if (_name != null && _name != "")
            {
                Console.WriteLine(_name);
                Console.WriteLine(_price);
                Console.WriteLine(_description);
            } else
                Console.WriteLine("No products");
        }

        //product data
        static string _name;
        static decimal _price;
        static string _description;


        private static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("L)ist product\n" +
                    "A)dd product\n" +
                    "Q)uit\n");

                string input = Console.ReadLine();

                if (input == "L")
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "Q")
                    return input[0];
                
                Console.Write("\nPlease choose a valid option");

            } while (true);
        }

































        static void PlayingWithPrimitives()
        {
            decimal unitPrice = 10.5m;

            //real declaration
            System.Decimal unitPrice2 = 10.5m;

            //current time
            System.DateTime now = DateTime.Now;

            ArrayList items;
        
        }

        static void PlayingWithVariables()
        {

            int hours = 8;
            double rate = 35.7;

            int hours2 = hours;

            string firstName, lastName;

            rate = 50;

            firstName = "dogcat";

            firstName = lastName = "what thats no name!";

            double ceiling = Math.Ceiling(rate);
            double floor = ceiling;

        }

    }
}
