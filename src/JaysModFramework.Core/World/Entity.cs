using System;

namespace JaysModFramework.Core.World;

/// <summary>
/// Abstract base for all framework-managed entities. Holds the live native
/// reference (<see cref="Native"/>) and a stable <see cref="Id"/>. Subclasses
/// provide property fallbacks for when the entity is unspawned.
/// </summary>
public abstract class Entity : IManagedEntity
{
    protected INativeEntity? Native { get; set; }

    public Guid Id { get; } = Guid.NewGuid();
    public bool IsSpawned => Native != null;
    public int Handle => Native?.Handle ?? 0;

    public abstract Vector3 Position { get; }
    public abstract float Heading { get; }
    public abstract string ModelName { get; }

    public bool Equals(INativeEntity other)
    {
        if (other is Entity managed) return Id == managed.Id;
        return IsSpawned && Handle == other.Handle;
    }

    public override bool Equals(object obj) => obj is INativeEntity e && Equals(e);
    public override int GetHashCode() => Id.GetHashCode();
}
