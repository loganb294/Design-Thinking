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
        private DateTime date;
        private string email;

        public Person(int id, string firstName, string lastName, string phone, DateTime date, string email)
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
