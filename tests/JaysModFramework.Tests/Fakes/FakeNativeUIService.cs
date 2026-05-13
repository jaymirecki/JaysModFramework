using System.Collections.Generic;
using JaysModFramework.Core.Native;

namespace JaysModFramework.Tests.Fakes;

public class FakeNativeUIService : INativeUIService
{
    public List<string> Notifications { get; } = new List<string>();

    public void Notify(string message) => Notifications.Add(message);
}
