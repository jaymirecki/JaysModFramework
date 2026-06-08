using System;

namespace JaysModFramework.Core.Native;

public interface INativeLifecycle
{
    event Action Tick;
    event Action<JmfControl> ControlClicked;
    event Action<JmfControl> ControlHeld;
    event Action<JmfControl> ControlDoubleClicked;
    event Action<JmfControl> DisabledControlClicked;
    event Action<JmfControl> DisabledControlHeld;
    event Action<JmfControl> DisabledControlDoubleClicked;
}
