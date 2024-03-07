using System.Reflection;
public interface IPlugin
{
    void Execute();
}
public class PdfExportPlugin : IPlugin
{
    public void Execute() => Console.WriteLine("Exporting PDF...");
}

public class ImageExportPlugin : IPlugin
{
    public void Execute() => Console.WriteLine("Exporting Image...");
}

public class PluginFactory
{
    public static IPlugin CreatePlugin(string pluginType)
    {
        var pluginTypeName = Assembly.GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(t => typeof(IPlugin).IsAssignableFrom(t) && t.Name.StartsWith(pluginType));

        if (pluginTypeName != null)
        {
            return (IPlugin)Activator.CreateInstance(pluginTypeName);
        }

        throw new ArgumentException("Unsupported plugin type");
    }
}

public class PluginManager
{
    private List<IPlugin> plugins = new List<IPlugin>();

    public void LoadPlugin(string pluginType)
    {
        IPlugin plugin = PluginFactory.CreatePlugin(pluginType);
        plugins.Add(plugin);
    }

    public void ExecuteAll()
    {
        foreach (var plugin in plugins)
        {
            plugin.Execute();
        }
    }
}
