using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary>
    ///     Provides info about a product. 
    /// </summary>
    public class Product
    {
        internal decimal DiscountPercentage = 0.10M;

        /// <summary>
        ///     Gets the product name
        /// </summary>
        /// <returns>The name</returns>
        public string GetName()
        {
            return _name ?? "";
        }

        /// <summary>
        ///     Sets the product name
        /// </summary>
        /// <param name="value">The name</param>
        public void SetName(string value)
        {
            _name = value ?? "";
        }



        /// <summary>
        ///     Validates the product
        /// </summary>
        /// <returns>Error Message, if any</returns>
        public string Validate()
        {
            if (String.IsNullOrEmpty(_name))
                return "name cannot be empty";
            if (_price < 0)
                return "Price must be >= 0";
            return "";
        }

        string _name = "";
        string _description;
        decimal _price;
        bool _isDiscontenued;


    }
}
