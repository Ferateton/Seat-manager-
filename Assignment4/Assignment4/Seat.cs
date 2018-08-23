using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPILabb6
{
    public class Seat
    {
        public int seatNr;
        public bool reserved;
        public string name;
        public double price;

        public Seat(int seatNr)
        {
            this.seatNr = seatNr;
            reserved = false;
            name = string.Empty;
            price = 0.0;
        }

        public override string ToString()
        {
            if (reserved)
            {
                return string.Format("{0, 3} {1, -8} {2,-18} {3, 10:f2}", seatNr, "Reserved", name, price);
            }
            else
            {
                return string.Format("{0, 3} {1, -8} {2,-18} {3, 10:f2}", seatNr, "Vacant", name, price);
            }
        }
    }
}
