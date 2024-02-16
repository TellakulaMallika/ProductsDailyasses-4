using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProducts
{
    public class Product
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public double PPrice { get; set; }
        public string PBrand { get; set; }
        public DateTime MfDate { get; set; }
        public DateTime ExpDate { get; set; }
    }
}
