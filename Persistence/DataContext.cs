using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Wtb.Domain;

namespace Persistence
{
    public class DataContext: DbContext
    {   
        public DataContext() : base() {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }  
        public DataContext(DbContextOptions<DataContext> options) : base (options) { 
            this.ChangeTracker.LazyLoadingEnabled = false;
        }        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Expertise> Expertises { get; set;}
        public DbSet<Demand> Demands { get; set;}
        public DbSet<Education> Educations { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {      
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data source=DB/wtb.db");
            }
        }


        public async System.Threading.Tasks.Task<List<Organization>> GetOrganizationsAsync() {
            var result = await this.Organizations
            .Include(o => o.Locations)
            .ToListAsync();
            return result;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            modelBuilder.Entity<Location>()
            .HasOne(l => l.Organization)
            .WithMany(o => o.Locations);
          
            modelBuilder.Entity<Expertise>()
            .HasOne(s => s.Organization)
            .WithMany(o => o.Expertises);

            modelBuilder.Entity<Skill>()
            .HasOne(s => s.Demand)
            .WithMany(d => d.DemandedSkills);

             modelBuilder.Entity<Skill>()
            .HasOne(s => s.Person)
            .WithMany(p => p.Skills);
        
              modelBuilder.Entity<Education>()
            .HasOne(e => e.Demand)
            .WithMany(d => d.DemandedEducations);
        
            modelBuilder.Entity<Demand>()
            .HasOne(d => d.Organization)
            .WithMany(o => o.DemandedRequests);

            FillDatabase(modelBuilder);
        }

        private void FillDatabase(ModelBuilder modelbuilder) {
           
            var organisaties = new List<Organization>();
            organisaties.Add( new Organization { Id = Guid.NewGuid(), Name = "Test Bedrijf", Branch = "ICT", Phonenumber = 121212121});
            organisaties.Add( new Organization { Id = Guid.NewGuid(), Name = "Test Bedrijf 2", Branch = "HRM", Phonenumber = 121212121}); 

            modelbuilder.Entity<Organization>()
                .HasData(organisaties);

            modelbuilder.Entity<Location>()
                .HasData(
                    new Location { Id = Guid.NewGuid(), Address = "Testweg 1", PostalCode = "8334 RK", City = "Tuk", OrganizationId = organisaties.Find(o  => o.Name.Equals("Test Bedrijf")).Id},
                    new Location { Id = Guid.NewGuid(), Address = "Testweg 2", PostalCode = "8334 RK", City = "De Basse", OrganizationId = organisaties.Find(o  => o.Name.Equals("Test Bedrijf")).Id}
                );
        }

        

    }
}
