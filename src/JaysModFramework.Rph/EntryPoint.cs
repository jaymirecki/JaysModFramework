using Rage;
using Rage.Attributes;

[assembly: Plugin("JaysModFramework",
    Author = "Jay Mirecki",
    Description = "JMF — GTA V RPG mod framework")]

namespace JaysModFramework.Rph;

public static class EntryPoint
{
    public static void Main()
    {
        Log.Info("JMF initializing");
        var menu = new InteractionMenuManager();
        Log.Info("JMF ready");

        while (true)
        {
            menu.Tick();
            GameFiber.Yield();
        }
    }

    public static void OnUnload(bool isShuttingDown)
    {
        Log.Info($"JMF unloading (shutting down: {isShuttingDown})");
    }
}
