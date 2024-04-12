using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_Amasing_Business
{
    public class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private string date;
        private string email;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Date { get => date; set => date = value; }
        public string Email { get => email; set => email = value; }

        public Person(int id, string firstName, string lastName, string phone, string date, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.date = date;
            this.email = email;
        }

        
    }
}
