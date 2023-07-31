using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Mobile
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public Manufacture Manufacture { get; set; }
    }

    public class Manufacture
    {
        public int Warranty { get; set; }

        public string IMEI { get; set; }
    }
}
