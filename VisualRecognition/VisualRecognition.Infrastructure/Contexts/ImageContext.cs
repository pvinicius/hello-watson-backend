using Microsoft.EntityFrameworkCore;
using VisualRecognition.Domain.Entities;

namespace VisualRecognition.Infrastructure.Contexts
{
    public class ImageContext : DbContext
    {
        public ImageContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Image> Image { get; set; }
    }
}
