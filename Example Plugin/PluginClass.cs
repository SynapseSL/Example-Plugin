using Synapse.Api.Plugin;
using Synapse.Translation;
using Synapse.Api;

namespace Example_Plugin
{
    [PluginInformation(
        Author = "Dimenzio",
        Description = "Example",
        LoadPriority = 0,
        Name = "ExamplePlugin",
        SynapseMajor = 2,
        SynapseMinor = 7,
        SynapsePatch = 0,
        Version = "2.0.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        [Config(section = "Example Plugin2")]
        public static PluginConfig Config { get; set; }

        [SynapseTranslation]
        public static new SynapseTranslation<PluginTranslation> Translation { get; set; }

        public override void Load()
        {
            SynapseController.Server.Logger.Info("Example Plugin Load");
            Logger.Get.Info(Translation.ActiveTranslation.LoggerMessage);

            new EventHandlers();
        }

        //This Method is only needed if you want to reload anything(Translation and Config will be reloaded by Synapse!)
        public override void ReloadConfigs()
        {
            
        }
    }
}
