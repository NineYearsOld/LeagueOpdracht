using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class LeagueContext : DbContext
    {
        public DbSet<Speler> Spelers { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<Team> Teams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SM28DAN\\SQLEXPRESS;Initial Catalog=LeagueEF;Integrated Security=True");
        }
    }
}
