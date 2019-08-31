using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Aplikacja.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

    }
}