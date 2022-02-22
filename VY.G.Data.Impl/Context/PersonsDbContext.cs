using Microsoft.EntityFrameworkCore;
using VY.G.Data.Contracts.Entities;

namespace VY.G.Data.Impl.Context
{
    public class PersonsDbContext : DbContext
    {
        public PersonsDbContext(DbContextOptions<PersonsDbContext> options) : base(options)
        {

        }

        public DbSet<PersonEntity> People { get; set; }
    }
}
