using Microsoft.EntityFrameworkCore;
using System;

namespace MyRazorApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public String Email { get; set; }
    }
}

