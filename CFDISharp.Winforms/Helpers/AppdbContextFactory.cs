using CFDISharp.Winforms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.Winforms.Helpers
{
    public class AppdbContextFactory : IDesignTimeDbContextFactory<AppdbContext>
    {
        public AppdbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppdbContext>();
            var s = @"Server=.\SQLEXPRESS;Database=cfdidb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(s);

            return new AppdbContext(optionsBuilder.Options);
        }
    }
}
