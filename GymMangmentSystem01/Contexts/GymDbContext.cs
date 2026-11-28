using GymMangmentSystem01.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymMangmentSystem01.Contexts
{
    public class GymDbContext : DbContext
    {
        //override protected void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        //{
        //    optionsBuilder.UseSqlServer ( "Server=(localdb)\\mssqllocaldb;Database=GymDB;Trusted_Connection=True;Encrypt=False" );
        //}
        public GymDbContext ( DbContextOptions options ) : base ( options )
        {

        }
        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfigurationsFromAssembly ( Assembly.GetExecutingAssembly ( ) );
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        public DbSet<Member> Mwmbwers { get; set; }
        public DbSet<Session> Sessions { get; set; }


    }
}
