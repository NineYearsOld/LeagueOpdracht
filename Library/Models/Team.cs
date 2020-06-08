using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Team
    {
        public int Id { get; set; }
        public int StamNummer { get; set; }
        public string Naam { get; set; }
        public string TrainerNaam { get; set; }
        public List<Speler> Spelers { get; set; } = new List<Speler>();

    }
}
