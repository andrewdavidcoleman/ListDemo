using System;
using System.Collections.Generic;

namespace ListDemo.Models
{
    public class Movie
    {
        public string imdbId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string Plot { get; set; }
    }
}