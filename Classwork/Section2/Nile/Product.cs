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
        ///     the products 
        /// </summary>
        public string Name = "";
        public string Description;
        public decimal Price;
        public bool isDiscontenued;
    }
}
