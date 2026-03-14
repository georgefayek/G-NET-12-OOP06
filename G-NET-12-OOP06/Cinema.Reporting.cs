using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP06
{
    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");

            int i = 1;
            foreach (var t in tickets)
            {
                Console.WriteLine($"[Ticket #{i}] {t.Movie} | {t.TypeName()} | Price: {t.Price} | Final: {t.FinalPrice():F2} | Booked: {(t.IsBooked ? "Yes" : "No")}");
                i++;
            }
        } 
    }
}
