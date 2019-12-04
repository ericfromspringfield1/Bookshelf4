using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Bookshelf4.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Books)
                .WithOne(b => b.Owner)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Author>()
                .Property("FirstName")
                .HasDefaultValue("Sam");
            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            builder.Entity<ApplicationUser>().HasData(user);

            ApplicationUser paul = new ApplicationUser
            {
                FirstName = "Paul",
                LastName = "Mudd",
                UserName = "paul@admin.com",
                NormalizedUserName = "PAUL@ADMIN.COM",
                Email = "paul@admin.com",
                NormalizedEmail = "PAUL@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db7945771",
                Id = "00000000-ffff-ffff-ffff-ffffffffffffg"
            };
            paul.PasswordHash = passwordHash.HashPassword(paul, "Admin8*");
            builder.Entity<ApplicationUser>().HasData(paul);

            Author haroldw = new Author()
            {
                Id = 1,
                FirstName = "Harold",
                LastName = "Whitecastle",
                PreferredGenre = "Square Burgers",
                UserCreatedId = user.Id
            };
            builder.Entity<Author>().HasData(haroldw);

            Book haroldkumar = new Book()
            {
                Id = 1,
                Title = "Harold & Kumar Go To White Castle",
                ISBN = "9092939449",
                Genre = "Squre Burgers",
                PublishDate = new DateTime(2005, 11, 14),
                AuthorId = haroldw.Id,
                OwnerId = user.Id
            };
            builder.Entity<Book>().HasData(haroldkumar);

        }
    }
}