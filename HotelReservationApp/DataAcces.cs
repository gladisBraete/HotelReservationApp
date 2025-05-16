using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gladis_Holtelz
{
    internal class DataAcces : IDataAcces
    {
        private string connString = "Integrated Security=SSPI;Initial Catalog=GladisHotelzz;Data Source=.;";
        public Client AddClient(Client client)
        {
            using (var connection = new SqlConnection(connString))
            {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO CLIENTS (FIRSTNAME, LASTNAME, EMAIL) VALUES (@FIRSTNAME, @LASTNAME, @EMAIL); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        cmd.Parameters.Add(new SqlParameter { ParameterName = "@FIRSTNAME", DbType = System.Data.DbType.String, Value = client.FirstName });
                        cmd.Parameters.Add(new SqlParameter { ParameterName = "@LASTNAME", DbType = System.Data.DbType.String, Value = client.LastName });
                        cmd.Parameters.Add(new SqlParameter { ParameterName = "@EMAIL", DbType = System.Data.DbType.String, Value = client.Email });

                        var id = (int)cmd.ExecuteScalar();
                        client.Id = id;
                    }
            }
            return client;
        }

        public Client[] GetAllClients()
        {
           List<Client> listClients = new List<Client>();   
           using(var connection = new SqlConnection(connString)) 
            { 
                connection.Open();
                using(var cmd = connection.CreateCommand()) 
                {
                    cmd.CommandText = "SELECT Id,FirstName, LastName, Email FROM Clients;";
                    SqlDataReader reader = cmd.ExecuteReader(); 
                    while(reader.Read())
                    {
                        Client client = new Client() {Id=reader.GetInt32(0), FirstName=reader.GetString(1), LastName=reader.GetString(2), Email=reader.GetString(3)};
                        listClients.Add(client);
                    }
                }
            }
            Client[] clients=listClients.ToArray();
            return clients;
        }

        public ChartReservation[] ChartReservation()
        {
            List<ChartReservation> chartReservation = new List<ChartReservation>();
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = @"SELECT r.Id, r.StartDate,r.EndDate,SUM(room.Price) as PricePerDay
                                    FROM dbo.Reservations r inner join dbo.ReservationDetails rd on r.Id = rd.ReservationId
                                    inner join dbo.Rooms room on room.Id = rd.RoomId
                                    GROUP BY r.Id,r.EndDate,r.StartDate;";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ChartReservation chRs = new ChartReservation() { Id = reader.GetInt32(0), StartDate = reader.GetDateTime(1), EndDate = reader.GetDateTime(2), PricePerDay = reader.GetDecimal(3) };
                        chartReservation.Add(chRs);
                    }

                }
                ChartReservation[] charts = chartReservation.ToArray();
                return charts;
            }
        }

        public Room[] GetAllRooms()
        {
            List<Room> listRooms = new List<Room>();
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Rooms ;";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Room room = new Room() { Id = reader.GetInt32(0), Number = reader.GetString(1), RoomType =reader.GetString(2), Price = reader.GetDecimal(3) };
                        listRooms.Add(room);
                    }
                }
            }
            Room[] rooms = listRooms.ToArray();
            return rooms;
        }

        public int[] GetReservationsId()
        {
            List<int> ids = new List<int>();    
            using(var connection = new SqlConnection(connString))
            {
                connection.Open();  
                using( var cmd=connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id FROM Reservations;";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        ids.Add(reader.GetInt32(0));
                    }
                }
            }
            int[] reservationsId=ids.ToArray();
            return reservationsId;
        }

        public decimal GetReservationPricePerDay(int reservationId)
        {
            decimal price = 0;
            using(var connection = new SqlConnection(connString))
            {
                connection.Open();
                using(var  cmd=connection.CreateCommand())
                {
                    cmd.CommandText = "Select sum(Rooms.price) from ReservationDetails inner join Rooms on ReservationDetails.RoomId=Rooms.Id where ReservationDetails.ReservationId=@reservationId;";
                    cmd.Parameters.AddWithValue("@reservationId", reservationId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                         price=reader.GetDecimal(0); 
                    }
                }
            }
            return price;
        }

        public Client GetClient(string emailAdress)
        {
            Client client = null;
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, FirstName, LastName, Email FROM Clients WHERE Email=@emailAdress;";
                    cmd.Parameters.AddWithValue("@emailAdress", emailAdress);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        client = new Client();
                        client.Id = reader.GetInt32(0);
                        client.FirstName = reader.GetString(1);
                        client.LastName = reader.GetString(2);
                        client.Email = reader.GetString(3);
                    }
                }
            }
            return client;
        }

        public Reservation GetReservation(int reservationId)
        {
            Reservation reservation1 = null;
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT ClientId, StartDate, EndDate FROM Reservations WHERE Id=@id";
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reservation1 = new Reservation() { ClientID = reader.GetInt32(0), CheckIn = reader.GetDateTime(1), CheckOut = reader.GetDateTime(2) };
                    }
                }
            }
            return reservation1;
        }

        public Room GetRoom(int roomId)
        {
            Room room = null;
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Number, RoomType, Price FROM Rooms WHERE Id=@Id;";
                    cmd.Parameters.AddWithValue("@Id", roomId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        room = new Room();
                        room.Number=reader.GetString(0);
                        room.RoomType =  reader.GetString(1);
                        room.Price = reader.GetDecimal(2);
                    }
                }
            }
            return room;
        }

        public DataTable RoomsAvailable(DateTime checkIn, DateTime checkOut)
        {
           using (var connection = new SqlConnection(connString))
           {
                connection.Open ();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = @"
                        select Id, Number, RoomType, Price, CAST(0 as BIT) as Selected
                        from Rooms 
                        where Id not in(
	                        select r.Id
	                        from Reservations rez
	                    inner join ReservationDetails rd on rez.Id=rd.ReservationId
	                    inner join Rooms r on r.Id=rd.RoomId
	                    where 
	                     rez.StartDate between @startDate and @endDate or rez.EndDate between @startDate and @endDate);";
                    cmd.Parameters.AddWithValue("@startDate", checkIn);
                    cmd.Parameters.AddWithValue("@endDate", checkOut);
                    SqlDataAdapter adapter =new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
           }
        }

        public Reservation SaveReservation(Reservation reservation)
        {
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Reservations (ClientId, StartDate, EndDate) VALUES (@ClientId,@StartDate, @EndDate);SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@ClientId", DbType = System.Data.DbType.Int32, Value = reservation.ClientID });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@StartDate", DbType = System.Data.DbType.Date, Value = reservation.CheckIn });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@EndDate", DbType = System.Data.DbType.Date, Value = reservation.CheckOut });

                    var id = (int)cmd.ExecuteScalar();
                    reservation.Id = id;
                }
                foreach (var detail in reservation.Details)
                {
                    using (var cmd2 = connection.CreateCommand())
                    {
                        cmd2.CommandText = "INSERT INTO ReservationDetails (ReservationId, RoomId) VALUES (@ReservationId, @RoomId); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        cmd2.Parameters.Add(new SqlParameter { ParameterName = "@ReservationId", DbType = System.Data.DbType.Int32, Value = reservation.Id });
                        cmd2.Parameters.Add(new SqlParameter { ParameterName = "@RoomId", DbType = System.Data.DbType.Int32, Value = detail.CurrentRoom.Id });
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
            return reservation;
        }

        public Room SaveRoom(Room room)
        {
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO ROOMS (Number,RoomType, Price) VALUES (@Number,@RoomType, @Price); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@RoomType", DbType = System.Data.DbType.String, Value = room.RoomType });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@Price", DbType = System.Data.DbType.Decimal, Value = room.Price });
                    cmd.Parameters.Add(new SqlParameter {ParameterName="@Number",DbType=System.Data.DbType.String,Value=room.Number });
                    var id = (int)cmd.ExecuteScalar();
                    room.Id = id;
                }
            }
            return room;
        }

        public DataTable ViewDetails(string email, string roomType, DateTime startDate, DateTime endDate)
        {    DataTable dt = new DataTable();
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {

                    cmd.CommandText = @"SELECT c.FirstName, c.LastName, c.Email, r.RoomType, rez.StartDate, rez.EndDate 
                        FROM Reservations rez 
                        INNER JOIN Clients c on rez.ClientId=c.Id 
                        INNER JOIN ReservationDetails rd on rd.ReservationId=rez.Id 
                        INNER JOIN Rooms r on r.Id=rd.RoomId 
                        WHERE (@email is null or  c.Email=@email ) 
                        AND (@roomType is null or r.RoomType=@roomType) 
                        AND (rez.StartDate between @startDate and @endDate or rez.EndDate between @startDate and @endDate);";

                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@roomType", string.IsNullOrEmpty(roomType) ? (object)DBNull.Value : roomType);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 
                    adapter.Fill(dt);
                }
            }
            return dt;   
        }

        public Dictionary<string, decimal> GetRoomTypes()
        {
            Dictionary<string,decimal> roomTypes= new Dictionary<string,decimal>();     
            using(var connection = new SqlConnection(connString))
            {
                connection.Open();
                using(var cmd= connection.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM RoomTypes;";
                    using (SqlDataReader red = cmd.ExecuteReader())
                    {
                        while (red.Read())
                        {
                            roomTypes.Add(red.GetString(0),red.GetDecimal(1));  
                        }
                    }
                }
            }
            return roomTypes;   
        }
    }
}
