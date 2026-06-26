namespace JaysModFramework.Core.World.SaveLoad;

/// <summary>
/// Top-level coordinator for save/load operations. Deserializes and applies
/// world and player state from disk, and serializes current state to disk.
/// </summary>
public class GameState
{
    private readonly IGameWorld _world;
    private readonly WorldStateSerializer _worldSerializer = new();
    private readonly PlayerStateSerializer _playerSerializer = new();

    public GameState(IGameWorld world)
    {
        _world = world;
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
        var playerState = _playerSerializer.Deserialize(savePath);

        // 3. Apply world properties (weather, datetime)
        _world.SetWeather(worldState.Weather);
        _world.SetDateTime(worldState.DateTime);

        // 4. Apply player state (model, position, heading, health, armor)
        // TODO: Implement once Player.SetModel() and property setters are added
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
