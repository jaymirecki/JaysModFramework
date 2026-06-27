namespace JaysModFramework.Core.Native;

/// <summary>
/// Native-facing game-level API, mirroring the "Game" entry point convention used
/// by both RPH (<c>Rage.Game</c>) and SHVDN (<c>GTA.Game</c>).
/// </summary>
public interface INativeGame
{
    INativePlayer Player { get; }
}
