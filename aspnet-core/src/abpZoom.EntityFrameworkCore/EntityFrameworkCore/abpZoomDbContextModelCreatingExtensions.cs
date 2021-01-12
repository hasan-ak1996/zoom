using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace abpZoom.EntityFrameworkCore
{
    public static class abpZoomDbContextModelCreatingExtensions
    {
        public static void ConfigureabpZoom(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(abpZoomConsts.DbTablePrefix + "YourEntities", abpZoomConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}