using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladis_Holtelz
{
    internal class Room
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public string Number {  get; set; }
        
        public decimal getRoomPrice(string roomType)
        {
            return MainForm.RoomTypes[roomType];
        }
        public Room(string type)
        {
            this.RoomType = type;
            this.Price = MainForm.RoomTypes[type];
        }
        public Room(string type, string number)
        {
            this.RoomType = type;
            this.Price = MainForm.RoomTypes[type];
            this.Number = number;
        }

        public Room() { }

        public override string ToString()
        {
            return "Camera: " + this.RoomType.ToString();
        }
    }
}
