using Synapse.Translation;

namespace Example_Plugin
{
    public class PluginTranslation : IPluginTranslation
    {
        public string LoggerMessage { get; set; } = "Logger Message";

        public string JoinMessage { get; set; } = "Hello User!";
    }
}
