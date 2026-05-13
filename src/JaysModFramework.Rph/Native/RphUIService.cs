using JaysModFramework.Core.Native;
using Rage;

namespace JaysModFramework.Rph.Native;

internal sealed class RphUIService : INativeUIService
{
    public void Notify(string message) => Game.DisplayNotification(message);
}
