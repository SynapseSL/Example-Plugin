using Synapse.Api;
using Synapse.Api.Plugin;
using Synapse.Translation;

namespace Example_Plugin
{
    [PluginInformation(
        Author = "Dimenzio",
        Description = "Example",
        LoadPriority = 0,
        Name = "ExamplePlugin",
        SynapseMajor = 2,
        SynapseMinor = 10,
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
            Logger.Get.Info(Translation.ActiveTranslation.LoggerMessage);

            new EventHandlers();
            base.Load();
        }
    }
}
