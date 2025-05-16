using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gladis_Holtelz
{
  [DataContract]
  internal class Client : IComparable
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public List<Reservation> Reservations { get; set; }=new List<Reservation>();
        public int CompareTo(object obj)
           {
                if(obj is Client)
                {
                if(this.Email==((Client)obj).Email)
                    {
                        return 0;
                    }
                }
            return -2;
           }

        public Client() { }

        public Client(string firstName, string lastName, string email, Reservation reservation)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Reservations.Add(reservation);
        }

        public Client(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public Client(string firstName)
        {
            this.FirstName=firstName;   
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
           
                sb.AppendLine("First Name: " + this.FirstName);
                sb.AppendLine("Last Name: " + this.LastName);
                sb.AppendLine("Email: " + this.Email);
          
            return sb.ToString();
        }
    }
}
