using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplikacja.Models
{
    public class Kategoria
    {
        public int KateogriaId { get; set; }
        [Required(ErrorMessage = "Podaj tytuł kursu")]
        [StringLength(50)]
        public string NazwaKategori { get; set; }
        public virtual ICollection<Kurs> Kurs { get; set; }
    }
}