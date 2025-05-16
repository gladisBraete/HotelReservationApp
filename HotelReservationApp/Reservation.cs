using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladis_Holtelz
{
    internal class Reservation : IPriceReservation
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public ReservationDetails[] Details { get; set; }
        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
            if (Details == null)
            {
                return totalPrice;
            }
            TimeSpan numarZile = this.CheckOut.Subtract(this.CheckIn);
            int numarZileRezervare = numarZile.Days;

            foreach (ReservationDetails details in Details)
            {
                totalPrice += details.CurrentRoom.Price;
            }

            return (numarZileRezervare*totalPrice);
        }

        public Reservation(int clientId, DateTime checkIn, DateTime checkOut)
        {
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.ClientID = clientId;
        }

        public Reservation() { }

        public static Reservation operator +(Reservation reservation, Room[] rooms)
        {
            var currentDetails = reservation.Details.ToList();
            for (int i = 0; i < rooms.Length; i++)
            {
                currentDetails.Add(new ReservationDetails { CurrentRoom = rooms[i], ReservationID = reservation.Id });
            }
            reservation.Details = currentDetails.ToArray();

            return reservation;
        }

        public override string ToString()
        {
            return "reservation in the period " + this.CheckIn.ToString("dd/MMMM/yyyy") + " - " + this.CheckOut.ToString("dd/MMMM/yyyy") + " with the price  " +  this.TotalPrice().ToString("N2");
        }
    }
}