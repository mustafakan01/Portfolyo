using Microsoft.EntityFrameworkCore;
using Portfolyo.DAL.Entities;

namespace Portfolyo.DAL.Context
{
    public class MyPortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-17UCK9J\\SQLEXPRESS;initial Catalog=MyPortfoloiDb; integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
