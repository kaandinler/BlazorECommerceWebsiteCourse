using Microsoft.EntityFrameworkCore;

namespace BlazorECommerceWebsiteCourse.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     id = 1,
                     Title = "Breaking Bad",
                     Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                     ImageUrl = "https://flxt.tmsimg.com/assets/p185846_b_h9_ad.jpg",
                     Price = 9.99m
                 },
                    new Product
                    {
                        id = 2,
                        Title = "Altered Carbon",
                        Description = "Set in a future where consciousness is digitized and stored, a prisoner returns to life in a new body and must solve a mind-bending murder to win his freedom.",
                        ImageUrl = "https://images.squarespace-cdn.com/content/v1/540efafce4b02e0dc20adb52/1520180035309-DVO0IGJFKF69ITB31Z6U/alteredcarbon.jpg?format=1500w",
                        Price = 4.99m
                    },
                    new Product
                    {
                        id = 3,
                        Title = "The Office",
                        Description = "A mockumentary on a group of typical office workers, where the workday consists of ego clashes, inappropriate behavior, and tedium.",
                        ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDNkOTE4NDQtMTNmYi00MWE0LWE4ZTktYTc0NzhhNWIzNzJiXkEyXkFqcGdeQXVyMzQ2MDI5NjU@._V1_FMjpg_UX1000_.jpg",
                        Price = 5.99m
                    }
                );
        }

        //DB Table of Product
        public DbSet<Product> Products { get; set; }
    }
}
