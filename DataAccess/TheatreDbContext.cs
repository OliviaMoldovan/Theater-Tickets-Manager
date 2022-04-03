using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DataAccess
{
    public class TheatreDbContext : IdentityDbContext<IdentityUser>
    {
        public TheatreDbContext(DbContextOptions<TheatreDbContext> options)
       : base(options)
        {
        }
        public DbSet<ShowEntity> ShowEntities { get; set; }

        public DbSet<TicketEntity> TicketEntities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.;Database=Dbtheatre;Trusted_Connection=True;");
        }

    }
}
