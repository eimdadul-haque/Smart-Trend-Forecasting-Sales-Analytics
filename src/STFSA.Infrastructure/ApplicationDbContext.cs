using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using STFSA.Domain.Entities;

namespace STFSA.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<AnomalyDetection> AnomalyDetections { get; set; }
        public DbSet<ForecastResult> ForecastResults { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<SalesDataset> SalesDatasets { get; set; }
    }
}
