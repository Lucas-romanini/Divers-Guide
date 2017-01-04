using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGrepo
{
   public class spotsVM
    {
        public List<Spot> spot { get; set; }
        public List<Categori> categori { get; set; }
        public List<rating> rating { get; set; }
        public List<SlaebeSteder> slaebesteder { get; set; }
        public List<SpotType> spottype { get; set; }
    }
}
