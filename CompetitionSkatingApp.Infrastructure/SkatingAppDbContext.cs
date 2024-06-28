//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CompetitionSkatingApp.Domain.Interfaces;
//using CompetitionSkatingApp.Domain.Factories;
//using CompetitionSkatingApp.Domain;

//namespace CompetitionSkatingApp.Infrastructure
//{
//    public class SkatingAppDbContext : DbContext
//    {
//        public DbSet<Competition> Competitions { get; set; }

//        public SkatingAppDbContext(DbContextOptions options) : base(options)
//        {
//        }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Competition>().HasData(SeedCompetitions());

//        }
//        private List<ICompetition> SeedCompetitions()
//        {
//            CompetitionFactory competitionFactory = new CompetitionFactory();
//            List<ICompetition> competitions = new List<ICompetition>(){
//                competitionFactory.CreateCompetition("Adult Masterclass latin", Domain.Discipline.LATIN, 5, Domain.AgeCategory.ADULT, null),
//                competitionFactory.CreateCompetition("Adult Amateur Ballroom", Domain.Discipline.STANDARD, 4, Domain.AgeCategory.ADULT, null),
//            };
//            return competitions;
//        }
//    }
//}
