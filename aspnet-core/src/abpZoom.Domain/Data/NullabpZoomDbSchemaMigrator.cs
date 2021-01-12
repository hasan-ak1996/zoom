using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abpZoom.Data
{
    /* This is used if database provider does't define
     * IabpZoomDbSchemaMigrator implementation.
     */
    public class NullabpZoomDbSchemaMigrator : IabpZoomDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}