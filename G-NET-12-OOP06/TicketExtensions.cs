using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP06
{
    using System;

    public static class TicketExtensions
    {
        public static string Receipt(this Ticket t)
        {
            return
            $@"========== RECEIPT ==========
          Movie    : {t.Movie}
          Type     : {t.GetType().Name}
          Price    : {t.Price}
          Final    : {t.FinalPrice():F2}
          Status   : {(t.IsBooked ? "Booked" : "Not Booked")}
        =============================";
            }

        public static double TotalRevenue(this Ticket[] tickets)
        {
            double total = 0;

            foreach (var t in tickets)
            {
                total += t.FinalPrice();
            }

            return total;
        }
    }

}
