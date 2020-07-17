﻿namespace AutoMapperDemo.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Test { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public string GetFullName()
        {
            return $"{this.LastName}, {this.FirstName}";
        }


        public string GetFullAdress()
        {
            return $"{this.Address.City} ---- {this.Address.Country}";
        }

    }

}
