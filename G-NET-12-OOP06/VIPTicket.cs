using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP06
{
    public class VIPTicket : Ticket
    {
        public bool Lounge { get; set; }
        public double Fee { get; set; }

        public VIPTicket(string movie, double price, bool lounge, double fee)
            : base(movie, price)
        {
            Lounge = lounge;
            Fee = fee;
        }

        public override double FinalPrice()
        {
            return (Price + Fee) * 1.14;
        }
    }
}
