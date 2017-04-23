using System;
#if NET451
using System.Configuration;
using System.Linq;
#endif
using System.Reflection;

namespace QuirksModeSwitchSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show whether running on .NET Core or .NET Framework
            Console.WriteLine(typeof(int).GetTypeInfo().Assembly.CodeBase);

#if NET451
            // Programmatically set the switch
            //ConfigurationManager.AppSettings.Set("switch:aspnet.test", "true");

            var value = ConfigurationManager.AppSettings.GetValues("switch:aspnet.test")?.FirstOrDefault();
            var success = bool.TryParse(value, out var isEnabled);
#else
            // Programmatically set the switch
            //AppContext.SetSwitch("switch:aspnet.test", true);
            
            var success = AppContext.TryGetSwitch("switch:aspnet.test", out var isEnabled);
#endif

            // Show switch value
            Console.WriteLine("Switch found? " + success);
            Console.WriteLine("Switch enabled? " + isEnabled);
        }
    }
}
