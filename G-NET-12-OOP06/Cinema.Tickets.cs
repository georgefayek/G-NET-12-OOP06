using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP06
{
    public partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===");
            Console.WriteLine("Projector ON\n");
        }

        public void Close()
        {
            Console.WriteLine("\nProjector OFF");
            Console.WriteLine("=== Cinema Closed ===");
        }

        public void AddTicket(Ticket t)
        {
            tickets.Add(t);
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }
    }
}
