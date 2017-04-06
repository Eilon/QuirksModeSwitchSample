using System;
using System.Reflection;

namespace QuirksModeSwitchSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(int).GetTypeInfo().Assembly.CodeBase);

            //AppContext.SetSwitch("switch:aspnet.test", true);

            var success = AppContext.TryGetSwitch("switch:aspnet.test", out var isEnabled);
            Console.WriteLine("Switch found? " + success);
            Console.WriteLine("Switch enabled? " + isEnabled);
        }
    }
}
