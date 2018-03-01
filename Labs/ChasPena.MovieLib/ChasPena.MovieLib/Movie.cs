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
    public class Movie
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

}
