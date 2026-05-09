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
        var menu = new InteractionMenuManager();

        while (true)
        {
            menu.Tick();
            GameFiber.Yield();
        }
    }

    public static void OnUnload(bool isShuttingDown)
    {
    }
}
