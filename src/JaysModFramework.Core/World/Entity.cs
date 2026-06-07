using System;

namespace JaysModFramework.Core.World;

/// <summary>
/// Abstract base for all framework-managed entities. Holds the live native reference
/// (<see cref="Native"/>) and a stable <see cref="Id"/>. Equality is by <see cref="Id"/>
/// so that the same entity compares equal across any number of managed wrapper instances.
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

    public bool Equals(IManagedEntity other)
    {
        if (other is null) return false;
        return Id == other.Id;
    }

    public override bool Equals(object obj) => obj is IManagedEntity e && Equals(e);
    public override int GetHashCode() => Id.GetHashCode();
}
