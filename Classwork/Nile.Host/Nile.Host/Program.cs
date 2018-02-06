/* Chas Pena
 * ITSE 1430
 * 
 * Section 1
 * 
 * 
 */





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
                switch (Char.ToUpper(choice))
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

                if(Decimal.TryParse(value, out decimal result))
                {
                    if (result >= minValue)
                        return result;

                }

                //string msg = String.Format("Value must be >= {0}" + minValue)
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
            //if (_name != null && _name != "")
            if (!String.IsNullOrEmpty(_name))
            {
                //display product


                //var msg = String.Format("{0} [${1}]", _name, _price);
                string msg = $"{_name} [${_price}]";
                Console.WriteLine(msg);


                if (!String.IsNullOrEmpty(_description))
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

                input = input.Trim();

                //padding 
                //input = input.PadLeft(10)

                //starts with
                //input.StartsWith(@"\");
                //input.EndsWith(@"\");
                
                //input.ToLower();
                input = input.ToUpper();

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

        static void PlayingWithReferences()
        {
            string message = "hello";
            string name = null;

            name = new string('*', 10);

            object instance = name;

            if (instance is string)
            {
                string str = (string)instance;
                Console.WriteLine(str);
            }else
                Console.WriteLine("not a string")

            string str2 = instance as string;

            //pattern matching
            if (instance is string str3)
            {
                
            }

            

        }
    }
}



