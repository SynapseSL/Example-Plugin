using Synapse.Config;

namespace Example_Plugin
{
    public class PluginConfig : IConfigSection
    {
        public string ConsoleColor { get; set; } = "red";
    }
}
