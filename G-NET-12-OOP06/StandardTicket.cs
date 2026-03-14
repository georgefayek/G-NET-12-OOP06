using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP06
{
    public class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public StandardTicket(string movie, double price, string seat)
            : base(movie, price)
        {
            Seat = seat;
        }

        public override double FinalPrice()
        {
            return Price * 1.14;
        }
    }
}
