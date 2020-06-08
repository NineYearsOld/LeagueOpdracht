using Library.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Library
{
    public class LeagueManager
    {
        private LeagueContext context = new LeagueContext();
        public void VoegSpeler(Speler speler)
        {
            context.Spelers.Add(speler);
            context.SaveChanges();
        }
        public void VoegTeamToe(Team team)
        {
            context.Teams.Add(team);
            context.SaveChanges();
        }
        public void VoegTransferToe(Transfer transfer)
        {
            transfer.Id = int.Parse(Console.ReadLine());
            transfer.Speler.Id = int.Parse(Console.ReadLine());
            transfer.Speler.Naam = Console.ReadLine();
            transfer.Speler.RugNummer = int.Parse(Console.ReadLine());
            context.Transfers.Add(transfer);
            context.SaveChanges();
        }
        public void UpdateSpeler(Speler speler)
        {
            speler.Id = int.Parse(Console.ReadLine());
            speler.Naam = Console.ReadLine();
            speler.RugNummer = int.Parse(Console.ReadLine());
            speler.Team.Id = int.Parse(Console.ReadLine());
            speler.Team.Naam = Console.ReadLine();

            context.Spelers.Update(speler);
            context.SaveChanges();
        }
        public void UpdateTeam(Team team)
        {
            team.Id = int.Parse(Console.ReadLine());
            team.Naam = Console.ReadLine();
            foreach (Speler speler in team.Spelers)
            {
                speler.Id = int.Parse(Console.ReadLine());
                speler.Naam = Console.ReadLine();
                speler.RugNummer = int.Parse(Console.ReadLine());
                speler.Waarde = int.Parse(Console.ReadLine());
            }
            team.StamNummer = int.Parse(Console.ReadLine());
            team.TrainerNaam = Console.ReadLine();

            context.Teams.Update(team);
            context.SaveChanges();
        }
        public Speler SelecteerSpeler(int spelerID)
        {
            var speler = context.Spelers.Where(a => a.Id == spelerID);
            return speler.FirstOrDefault();
        }
        public Team SelecteerTeam(int stamnummer)
        {
            var speler = context.Teams.Where(a => a.Id == stamnummer);
            return speler.FirstOrDefault();
        }
        public Transfer SelecteerTransfer(int transferID)
        {
            var transfer = context.Transfers.Where(a => a.Id == transferID);
            return transfer.FirstOrDefault();
        }

    }
}
