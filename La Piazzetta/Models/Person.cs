using System;
using System.Collections.Generic;

namespace La_Piazzetta.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public List<Order> Orders { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Vote> Votes { get; set; }
        public List<Favourites> Favourites { get; set; }
    }
}