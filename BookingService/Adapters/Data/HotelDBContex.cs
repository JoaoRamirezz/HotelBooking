using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class HotelDBContex : DbContext
    {
        public HotelDBContex(DbContextOptions<HotelDBContex> options) : base(options) { }
        
        public virtual DbSet<Domain.Entities.Guest> Guest { get; set; }

        
    }
}
