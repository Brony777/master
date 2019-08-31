using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacja.Models
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }
        public DateTime DataZamowienia { get; set; }
        public string StanZamowienia { get; set; }

        List<PozycjaZamowienia> PozycjeZamowienia { get; set; }

    }
    public enum StanZmowienia
    {
        Nowe,
        Zrealizowane
    }
}