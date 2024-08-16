using Plugins;
using System.Reflection;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pluginPath = "Plugins.dll"; // Assume plugins are compiled into Plugins.dll

            // Load the Plugins assembly dynamically
            Assembly assembly = Assembly.LoadFrom(pluginPath);

            // Get all types that implement IPlugin
            Type pluginInterface = typeof(IPlugin);
            var pluginTypes = assembly.GetTypes();

            foreach (var type in pluginTypes)
            {
                if (pluginInterface.IsAssignableFrom(type) && !type.IsInterface)
                {
                    // Create an instance of the plugin
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(type);

                    Console.WriteLine($"Executing {plugin.Name}");
                    plugin.Execute();
                    Console.WriteLine("------------------------");
                }
            }

        }
    }
}
