using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppAshLab3.Models
{
    public partial class Login
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
