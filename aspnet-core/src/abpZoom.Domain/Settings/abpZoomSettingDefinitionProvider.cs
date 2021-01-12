using Volo.Abp.Settings;

namespace abpZoom.Settings
{
    public class abpZoomSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(abpZoomSettings.MySetting1));
        }
    }
}
