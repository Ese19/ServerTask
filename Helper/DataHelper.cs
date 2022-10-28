using Microsoft.EntityFrameworkCore;
using ServerTask.Data;

namespace ServerTask.Helper;
public static class DataHelper
{
    public static async Task ManageDataAsync(IServiceProvider svcProvider)
    {
        var dbContextSvc = svcProvider.GetRequiredService<AppDbContext>();

        await dbContextSvc.Database.MigrateAsync();
    } 
}