using System;
using System.Collections.Generic;

namespace TrackStatMobile.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }    
        //public List<Stats> Statistics { get; set; }
    }
}