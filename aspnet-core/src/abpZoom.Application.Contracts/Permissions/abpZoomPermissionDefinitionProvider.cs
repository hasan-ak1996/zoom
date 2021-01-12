using abpZoom.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abpZoom.Permissions
{
    public class abpZoomPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(abpZoomPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(abpZoomPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<abpZoomResource>(name);
        }
    }
}
