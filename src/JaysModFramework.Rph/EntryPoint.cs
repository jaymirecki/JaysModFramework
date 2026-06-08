using JaysModFramework.Core;
using JaysModFramework.Rph.Native;
using Rage.Attributes;

[assembly: Plugin("JaysModFramework",
    Author = "Jay Mirecki",
    Description = "JMF — GTA V RPG mod framework")]

namespace JaysModFramework.Rph;

public static class EntryPoint
{
    public static void Main()
    {
        var nativeFramework = new RphNativeFramework();
        Framework framework = new Framework(nativeFramework);

        ((RphLifecycleService)nativeFramework.Lifecycle).Run(framework);
    }

    public static void OnUnload(bool isShuttingDown)
    {
    }
}
