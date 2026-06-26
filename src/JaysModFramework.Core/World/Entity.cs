using System;
using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Abstract base for all framework-managed entities. Holds the live native reference
/// (<see cref="Native"/>) and a stable <see cref="Id"/>. Equality is by <see cref="Id"/>
/// so that the same entity compares equal across any number of managed wrapper instances.
/// </summary>
public abstract class Entity : ISaveableEntity, IEquatable<Entity>
{
    protected INativeEntity? Native { get; set; }

    public Guid Id { get; } = Guid.NewGuid();
    public bool IsSpawned => Native != null;
    public int Handle => Native?.Handle ?? 0;

    public Vector3 Position
    {
        get => Native?.Position ?? default;
        set
        {
            if (Native != null)
                Native.Position = value;
        }
    }
    public float Heading
    {
        get => Native?.Heading ?? default;
        set
        {
            if (Native != null)
                Native.Heading = value;
        }
    }
    public int Health
    {
        get => Native?.Health ?? default;
        set
        {
            if (Native != null)
                Native.Health = value;
        }
    }
    public abstract string ModelName { get; }

    public bool Equals(Entity other)
    {
        if (other is null) return false;
        return Id == other.Id;
    }

    public override bool Equals(object obj) => obj is Entity e && Equals(e);
    public override int GetHashCode() => Id.GetHashCode();
}
