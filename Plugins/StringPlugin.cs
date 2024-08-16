namespace Plugins
{
    public class StringPlugin : IPlugin
    {
        public string Name => "String Plugin";

        public void Execute()
        {
            string original = "Hello, Friend";
            string reversed = new string(original.Reverse().ToArray());
            Console.WriteLine($"[StringPlugin] Reversed string : {reversed}");
        }
    }
}
