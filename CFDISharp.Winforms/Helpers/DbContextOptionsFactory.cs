using CFDISharp.Winforms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.Winforms.Helpers
{
	public class DbContextOptionsFactory
	{
		public static DbContextOptions<AppdbContext> Get(string connectionString)
		{

			var options = new DbContextOptionsBuilder<AppdbContext>();
			options.UseSqlServer(connectionString);
			return options.Options;
		}
	}
}
