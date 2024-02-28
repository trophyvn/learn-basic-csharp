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

public class PluginManager
{
    private List<IPlugin> plugins = new List<IPlugin>();

    public void LoadPlugin(string pluginType)
    {
        switch (pluginType)
        {
            case "PDF":
                plugins.Add(new PdfExportPlugin());
                break;
            case "Image":
                plugins.Add(new ImageExportPlugin());
                break;
            default:
                throw new ArgumentException("Unsupported plugin type");
        }
    }

    public void ExecuteAll()
    {
        foreach (var plugin in plugins)
        {
            plugin.Execute();
        }
    }
}
