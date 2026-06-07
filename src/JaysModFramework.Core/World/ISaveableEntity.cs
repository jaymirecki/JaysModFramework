namespace JaysModFramework.Core.World;

/// <summary>
/// The persistable data contract shared by <see cref="PersistentEntity"/> (serialised backing store)
/// and live <see cref="Entity"/> wrappers. Defines the minimum set of properties that can be
/// saved and loaded independently of the native engine.
/// </summary>
public interface ISaveableEntity
{
    Vector3 Position { get; }
    float Heading { get; }
    string ModelName { get; }
}
