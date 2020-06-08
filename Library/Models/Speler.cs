using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Speler
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int RugNummer { get; set; }
        public decimal Waarde { get; set; }
        public Team Team {get; set;}
        public Speler(string naam, int rugNummer, decimal waarde)
        {
            Id = generateID();
            Naam = naam;
            RugNummer = rugNummer;
            Waarde = waarde;
        }
        public int generateID()
        {
            return new Random().Next();
        }
    }
}
