namespace JaysModFramework.Core.World.SaveLoad;

/// <summary>
/// Top-level coordinator for save/load operations. Deserializes and applies
/// world and player state from disk, and serializes current state to disk.
/// </summary>
public class GameState
{
    /// <summary>
    /// Load world and player state from disk and apply to the live game.
    /// Phase 1 MVP: loads player (position, heading, model, health, armor) and world (weather, datetime).
    /// </summary>
    public void Load(string savePath)
    {
        // TODO Phase 1: Implement MVP load flow
        // 1. Deserialize WorldState ← savePath/world.xml
        // 2. Deserialize PlayerState ← savePath/player.xml
        // 3. Apply world properties (weather, datetime)
        // 4. Apply player state (model, position, heading, health, armor)
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
