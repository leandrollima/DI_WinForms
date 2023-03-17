using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POC.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.EFCore.Configuration
{
    public static class ConfigRepository
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection serviceCollection, string stringConnection)
        {
            serviceCollection.AddDbContextFactory<AppDbContext>(options => {
                options.UseNpgsql(stringConnection);
            });

            return serviceCollection;
        }
    }
}
