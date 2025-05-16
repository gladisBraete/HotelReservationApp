using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladis_Holtelz
{
    internal interface IDataAcces
    {
        Room GetRoom(int roomId);
        Room[] GetAllRooms();
        int[] GetReservationsId();
        decimal GetReservationPricePerDay(int reservationId);   
        Room SaveRoom(Room room);
        Client GetClient(string emailAdress);
        Client AddClient(Client client);
        Reservation GetReservation(int reservationId);
        Reservation SaveReservation(Reservation reservation);
        Client[] GetAllClients();
        DataTable ViewDetails(string email, string roomType, DateTime startDate, DateTime endDate);
        DataTable RoomsAvailable(DateTime checkIn, DateTime checkOut);
        ChartReservation[] ChartReservation();

        Dictionary<string, decimal> GetRoomTypes();
    }
}
