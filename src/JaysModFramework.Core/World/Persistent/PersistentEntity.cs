namespace JaysModFramework.Core.World;

/// <summary>
/// Serializable backing store for an entity. Holds a snapshot of all
/// <see cref="INativeEntity"/> properties so they can be read when the entity
/// is unspawned and written to/from XML on save and load.
/// </summary>
public abstract class PersistentEntity : ISaveableEntity
{
    public Vector3 Position { get; set; }
    public float Heading { get; set; }
    public string ModelName { get; set; } = string.Empty;
    public int Health { get; set; }
}
