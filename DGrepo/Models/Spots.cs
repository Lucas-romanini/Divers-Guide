using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGrepo
{
   public class Spots
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string MinDepth { get; set; }
        public string MaxDepth { get; set; }
        public int CategoriID { get; set; }
        public int CommentID { get; set; }
        public int RatingID { get; set; }
    }
}
