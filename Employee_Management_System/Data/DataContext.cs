using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System.Data
{
	public class DataContext : IdentityDbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
	}
}
