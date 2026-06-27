using System;

namespace JaysModFramework.Core.World.SaveLoad;

/// <summary>
/// Top-level coordinator for save/load operations. Deserializes and applies
/// world and player state from disk, and serializes current state to disk.
/// </summary>
public class GameState
{
    private readonly Framework _framework;
    private readonly WorldStateSerializer _worldSerializer = new();
    private readonly PlayerStateSerializer _playerSerializer = new();

    public GameState(Framework framework)
    {
        _framework = framework;
    }

    /// <summary>
    /// Load world and player state from disk and apply to the live game.
    /// Phase 1 MVP: loads player (position, heading, model, health, armor) and world (weather, datetime).
    /// </summary>
    public void Load(string savePath)
    {
        // 1. Deserialize WorldState ← savePath/world.xml
        var worldState = _worldSerializer.Deserialize(savePath);

        // 2. Deserialize PlayerState ← savePath/player.xml
        PlayerState playerState;
        try {
            playerState = _playerSerializer.Deserialize(savePath);
        }
        catch (Exception ex) {
            _framework.Game.Logger.Error($"Loading player state failed - {ex}");
            return;
        }

        // 3. Apply world properties (weather, datetime)
        _framework.World.SetWeather(worldState.Weather);
        _framework.World.SetDateTime(worldState.DateTime);

        // 4. Apply player state (model, position, heading, health, armor)
        // Model change must happen first (replaces native ped)
        _framework.Game.Player.SetModel(playerState.Ped.ModelName);
        var playerPed = _framework.Game.Player.Ped;
        playerPed.Position = playerState.Ped.Position;
        playerPed.Heading = playerState.Ped.Heading;
        playerPed.Health = playerState.Ped.Health;
        playerPed.Armor = playerState.Ped.Armor;
    }

    /// <summary>
    /// Save current world and player state to disk.
    /// Phase 2 MVP: saves player (position, heading, model, health, armor) and world (weather, datetime).
    /// </summary>
    public void Save(string savePath)
    {
        // TODO Phase 2: Implement MVP save flow
        // 1. Read live world state (weather, datetime)
        // 2. Read live player ped state (position, heading, model, health, armor)
        // 3. Serialize WorldState → savePath/world.xml
        // 4. Serialize PlayerState → savePath/player.xml
    }
}
