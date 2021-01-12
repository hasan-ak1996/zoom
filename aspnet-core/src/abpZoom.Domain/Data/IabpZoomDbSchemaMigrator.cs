using System.Threading.Tasks;

namespace abpZoom.Data
{
    public interface IabpZoomDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
