using System;
using System.Reflection;

namespace QuirksModeSwitchSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show whether running on .NET Core or .NET Framework
            Console.WriteLine(typeof(int).GetTypeInfo().Assembly.CodeBase);

            // Programmatically set the switch
            //AppContext.SetSwitch("switch:aspnet.test", true);

            // Show switch value
            var success = AppContext.TryGetSwitch("switch:aspnet.test", out var isEnabled);
            Console.WriteLine("Switch found? " + success);
            Console.WriteLine("Switch enabled? " + isEnabled);
        }
    }
}
