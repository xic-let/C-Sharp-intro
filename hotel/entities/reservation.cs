using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.entities
{
    internal class reservation
    {
        private int Roomnbr { get; set; }
        private DateTime Checkin { get; set; }

        private DateTime Checkout { get; set; }

        //construtores

        public reservation()
        { }

        public reservation(int roomnbr, DateTime checkin, DateTime checkout)
        {
            Roomnbr = roomnbr;
            Checkin = checkin;
            Checkout = checkout;
        }

        //metodos
        //
        public int Duration()
        {
            TimeSpan duration =Checkout.Subtract.(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkout)
        {
            Checkin = checkIn;
            Checkout = checkout;

        }

        public override string ToString()
        {
            return "Room: "
                + Roomnbr
                + " ,check-in: "
                + Checkin.ToString("dd/MM/yyy")
                + " ,check-out: "
                + Checkout.ToString("dd/MM/yyy")
                + ", "
                + Duration()
                + " Nights";


        }
    }
}
