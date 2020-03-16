using System;
using System.Collections.Generic;

namespace TrackStatMobile.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string UserEmail { get; set; } 
        public string UserPassword { get; set; }    
        //public List<Stats> Statistics { get; set; }
    }
}