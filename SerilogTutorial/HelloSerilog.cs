using System;
using Serilog;

namespace SerilogTutorial
{
    public class HelloSerilog
    {
        public static void Main(string[] args)
        {
            // Create Logger
            Log.Logger = new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger();
            // Output logs
            Log.Information("Hello, Serilog!");
        }
    }
}