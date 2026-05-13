using JaysModFramework.Core.Native;

namespace JaysModFramework.Tests.Fakes;

public class FakeNativeFramework : INativeFramework
{
    public string GameDirectory { get; set; } = string.Empty;
    public FakeNativeUIService UIService { get; } = new FakeNativeUIService();

    INativeUIService INativeFramework.UIService => UIService;
}
