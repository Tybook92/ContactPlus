using ContactPlus.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactPlus.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            //get an instance of the db appliaction context
            var dbContextSvc = svcProvider.GetRequiredService<ApplicationDbContext>();
            
            //migration: this is equivalent to update-database
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
