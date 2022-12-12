using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Category { get; set; }
        public DbSet<StoneCategoris> StoneCategory { get; set; }
        public DbSet<StoneItemCategories> StoneItemCategory { get; set; }
        public DbSet<AnotherAnotherCategories> AnotherAnotherCategory { get; set; }
        public DbSet<AnotherPieces> AnotherPiece { get; set; }
        public DbSet<KartItem> KartItems { get; set; }
    }
}