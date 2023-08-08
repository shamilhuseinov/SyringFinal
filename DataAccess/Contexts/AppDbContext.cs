using System;
using Common.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
	public class AppDbContext:IdentityDbContext<User>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{
			
		}
        public DbSet<Slider> Sliders { get; set; }
	}
}

