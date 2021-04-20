using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


public class Context : IdentityDbContext<User>
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Content> Content { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<UserOrder> UserOrders { get; set; }



    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>().ToTable("User");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        builder.Entity<IdentityRole>().ToTable("Roles");


        string adminRoleId = "0a880cc1-659a-4635-be2a-eef833e2096a";
        string customerRoleId = "46e8fe91-21d2-49bf-8607-bebd2c1d810a";

        builder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = adminRoleId,
            Name = "Admin",
            NormalizedName = "ADMIN"

        });

        builder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = customerRoleId,
            Name = "Customer",
            NormalizedName = "CUSTOMER"

        });

        builder.Entity<Content>().HasData(new Content("About", ToolBox.ContentBodyDemo, true, true));
        builder.Entity<Content>().HasData(new Content("FAQ", ToolBox.ContentBodyDemo, false, true));
        builder.Entity<Content>().HasData(new Content("Contact", ToolBox.ContentBodyDemo, true, true, "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg"));

        builder.Entity<Book>().HasData(new Book(

            "The Midnight Library",
            ToolBox.ContentBodyDemo,
            "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7868/9781786892737.jpg",
            100.0, 
            10

            ));

        builder.Entity<Book>().HasData(new Book(

            "Such a Fun Age : 'The book of the year' Independent",
            ToolBox.ContentBodyDemo,
            "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5266/9781526612168.jpg",
            100.0,
            10

            ));


        builder.Entity<Book>().HasData(new Book(

            "The Choice : A true story of hope",
            ToolBox.ContentBodyDemo,
            "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/8460/9781846045127.jpg",
            50.0,
            10,
            50,
            true,
            true

            ));


        builder.Entity<Book>().HasData(new Book(
            "Becoming : The Sunday Times Number One Bestseller",
            ToolBox.ContentBodyDemo,
            "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/2419/9780241982976.jpg",
            120.0,
            10,
            10,
            true,
            true


            ));

        builder.Entity<Book>().HasData(new Book(

            "Atomic Habits : the life-changing million-copy #1 bestseller",
            ToolBox.ContentBodyDemo,
            "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/8479/9781847941831.jpg",
            175.0,
            10,
            20,
            false,
            true

            ));
          builder.Entity<Book>().HasData(new Book(

            "Can't Hurt Me",
            ToolBox.ContentBodyDemo,
            "https://image.bokus.com/images/9781544512266_200x_cant-hurt-me_e-bok",
            245.0,
            10,
            20,
            false,
            true
             ));




      



    }
}
