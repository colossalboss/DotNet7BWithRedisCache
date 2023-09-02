using System;
using DockerDotNet7.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerDotNet7.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
		{
		}

		public DbSet<Product> Products { get; set; }
	}
}


