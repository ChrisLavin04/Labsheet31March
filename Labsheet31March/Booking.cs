using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet31March
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingsDate { get; set; }
        public int NumberOfParticipants { get; set; }
        public virtual Customer Customer { get; set; }
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public string ContactNumber { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }

    public class BookingData : DbContext
    {
        public BookingData() : base("MyCustomerData") { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
