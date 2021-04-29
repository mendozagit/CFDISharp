using Microsoft.EntityFrameworkCore;

namespace CFDISharp.Winforms.Models
{
    public class MigrationService : IMigrationService
    {
        private readonly AppdbContext context;

        public MigrationService(AppdbContext context)
        {
            this.context = context;
        }
        public void Migrate()
        {
            using (context)
            {
                context.Database.Migrate();
            }
        }
    }
}
