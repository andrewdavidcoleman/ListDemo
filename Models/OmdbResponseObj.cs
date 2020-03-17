using System.Collections.Generic;

namespace ListDemo.Models
{
    public class OmdbResponseObj
    {
        public List<Movie> Search { get; set; }
        public int totalResults { get; set; }
        public bool Response { get; set; }
    }
}