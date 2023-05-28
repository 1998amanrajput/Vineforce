using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Vineforce.CandidateTest.EntityFrameworkCore
{
    public static class CandidateTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CandidateTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CandidateTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
