using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP06
{
    public abstract class Ticket
    {
        public string Movie { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get; private set; }

        public Ticket(string movie, double price)
        {
            Movie = movie;
            Price = price;
        }

        // abstract method
        public abstract double FinalPrice();

        // virtual method
        public virtual string TypeName()
        {
            return this.GetType().Name;
        }

        // concrete methods
        public void Book()
        {
            IsBooked = true;
        }

        public void Cancel()
        {
            IsBooked = false;
        }
    }
}
