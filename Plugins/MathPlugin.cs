namespace Plugins
{
    public class MathPlugin : IPlugin
    {
        public string Name => "Math Plugin";

        public void Execute()
        {
            int result = 5 + 10;
            Console.WriteLine($"[MathPlugin] 5 + 10 = {result}");
        }
    }
}
