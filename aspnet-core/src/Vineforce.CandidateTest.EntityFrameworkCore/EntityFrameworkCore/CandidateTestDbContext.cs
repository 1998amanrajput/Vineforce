using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vineforce.CandidateTest.Authorization.Roles;
using Vineforce.CandidateTest.Authorization.Users;
using Vineforce.CandidateTest.MultiTenancy;

namespace Vineforce.CandidateTest.EntityFrameworkCore
{
    public class CandidateTestDbContext : AbpZeroDbContext<Tenant, Role, User, CandidateTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Entities.State> States { get; set; }
        public DbSet<Entities.Country> Countries { get; set; }

        public CandidateTestDbContext(DbContextOptions<CandidateTestDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entities.Country>()
                .HasMany(country => country.States)
                .WithOne(state => state.Country)
                .HasForeignKey(country => country.CountryId);
        }
    }
}
