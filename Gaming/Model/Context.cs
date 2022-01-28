using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gaming.Model
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=LAPTOP-BMNLMC6L; database=Gaming_DB; integrated security=true;");
		}

		public DbSet<Users> Userss { get; set; }

	}
}
