using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Contacto
    {

        protected string? Name {  get; set; }

        protected string? Address { get; set; }
        protected string? City { get; set; }

        protected string? Phone { get; set; }

        protected string? Email { get; set; }
        public Contacto(string name, string adress, string city, string phone, string email) 
        {
            this.Name = name;
            this.Address = adress;
            this.City = city;
            this.Phone = phone;
            this.Email = email;
        }
        public override string ToString()
        {
            return $"Name: {Name} - Address: {Address} - Email: {Email} - Phone: {Phone}";
        }


        public string GetName()
        {
            return $"{Name}";
        }
        public string GetAddress()
        {
            return $"{Address}";
        }
        public string GetEmail()
        {
            return $"{Email}";
        }
        public string GetPhone()
        {
            return $"{Phone}";
        }
        public void SetName( string name)
        {
            this.Name = name;
   
        }
        public void SetEmail( string email)
        {
            this.Email = email;

        }
        public void SetAddress( string address)
        {
            this.Address = address;

        }
        public void SetPhone( string phone)
        {
            this.Phone = phone;

        }



    }
}
