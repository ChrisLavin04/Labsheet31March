using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labsheet31March;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookingData db = new BookingData();

            using(db)
            {

                Customer c1 = new Customer() { Name = "Tom Jones", ContactNumber = "086-123 4567" };
                Booking b1 = new Booking() { BookingId = 1, CustomerId = 1, BookingDate = new DateTime(09/03/2025), NumberOfParticipants = 1};
                
                Customer c2 = new Customer() { Name = "Mary Smith", ContactNumber = "086 546 3214" };
                Booking b2 = new Booking() { BookingId = 2, CustomerId = 2, BookingDate = new DateTime(12/03/2025), NumberOfParticipants = 2 };

                Customer c3 = new Customer() { Name = "Jo Doyle", ContactNumber = "087 1221 222" };
                Booking b3 = new Booking() { BookingId = 3, CustomerId = 3, BookingDate = new DateTime(18/03/2025), NumberOfParticipants = 3 };


                Console.WriteLine("Customers Created");

                db.Customers.Add(c1);
                db.Customers.Add(c2);
                db.Customers.Add(c3);

                Console.WriteLine("Added Customers to database");

                db.Bookings.Add(b1);
                db.Bookings.Add(b2);
                db.Bookings.Add(b3);

                Console.WriteLine("Added Bookings to database");

                db.SaveChanges();

                Console.WriteLine("Changes Saved.");
            }
        }
    }
}
