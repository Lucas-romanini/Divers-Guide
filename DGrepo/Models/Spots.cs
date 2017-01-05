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
        public string Long { get; set; }
        public string Lati { get; set; }
        public string Name { get; set; }
        public string Beskrivelse { get; set; }
        public string Location { get; set; }
        public string MinDepth { get; set; }
        public string MaxDepth { get; set; }
        public string Billede { get; set; }
        public int CategoriID { get; set; }
        public int CommentID { get; set; }

    }
}
