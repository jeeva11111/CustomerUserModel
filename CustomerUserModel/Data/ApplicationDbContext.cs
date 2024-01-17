using CustomerUserModel.Models;
using CustomerUserModel.Models.DisplayModel;
using Microsoft.EntityFrameworkCore;

namespace CustomerUserModel.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<User> Users { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<State> States { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<UploadImage> UploadImages { get; set; }
	}
}
