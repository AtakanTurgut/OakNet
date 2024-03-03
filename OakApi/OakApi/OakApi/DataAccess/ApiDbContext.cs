using Microsoft.EntityFrameworkCore;
using OakApi.Model;

namespace OakApi.DataAccess
{
	public class ApiDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-R6K64T9\\SQLEXPRESS;database=OakApiDb;integrated security=true;");
		}

		public DbSet<Person> Persons { get; set; }
		public DbSet<Position> Positions { get; set; }
		public DbSet<Salary> Salaries { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<PersonDetail> PersonDetails { get; set; }
	}
}
