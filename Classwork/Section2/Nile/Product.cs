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

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value ?? ""; }
        }

        //auto-propertys
        public decimal Price
        { get; set; } = 0;


        public decimal ActualPrice
        {
            get
            {
                if (IsDiscontinued)
                    return Price - (Price * DiscountPercentage);

                return Price;
            }
            set { }
        }
        public bool IsDiscontinued { get; set; }

        ///// <summary>
        /////     Gets the product name
        ///// </summary>
        ///// <returns>The name</returns>


        //public string GetName()
        //{
        //    return _name ?? "";
        //}

        ///// <summary>
        /////     Sets the product name
        ///// </summary>
        ///// <param name="value">The name</param>
        //public void SetName(string value)
        //{
        //    _name = value ?? "";
        //}


        /// <summary>
        ///     Validates the product
        /// </summary>
        /// <returns>Error Message, if any</returns>
        public string Validate()
        {
            if (String.IsNullOrEmpty(_name))
                return "name cannot be empty";
            if (Price < 0)
                return "Price must be >= 0";
            return "";
        }

        string _name = "";
        string _description;
        //decimal _price;
        //bool _isDiscontenued;


    }
}
