using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasPena.MovieLib
{
    /// <summary>
    ///                             Represents a Movie
    /// </summary>
    /// 
    //string _name = "";
    //string _description;
    //decimal _price;
    //bool _isDiscontenued;

    public class Film
    {
        public string Title
        { get; set; }
        public string Desctiption
        { get; set; }
        public int Length
        { get; set; }
        public bool Owned
        { get; set; }
    }
    //public decimal Price????
    //{ get; set; } = 0;

    //public decimal ActualPrice???
    //{
    //    get
    //    {
    //        if (IsDiscontinued)
    //            return Price - (Price * DiscountPercentage);

    //        return Price;
    //    }
    //    set { }
    //}
    //public bool IsDiscontinued { get; set; }
    //public string Validate()
    //{
    //    if (String.IsNullOrEmpty(_name))
    //        return "name cannot be empty";
    //    if (Price < 0)
    //        return "Price must be >= 0";
    //    return "";
    //}

}
