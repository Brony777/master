using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplikacja.Models
{
    public class Kurs
    {
        public int KursId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Podaj tytuł kursu")]
        public string TytulKursu { get; set; }
        public DateTime DataDodania { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}