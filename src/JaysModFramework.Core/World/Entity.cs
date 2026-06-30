using System;
using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Abstract base for all framework-managed entities. Holds the live native reference
/// (<see cref="Native"/>) and a stable <see cref="Id"/>. Equality is by <see cref="Id"/>
/// so that the same entity compares equal across any number of managed wrapper instances.
/// Subclasses that have a persistent backing store (e.g. <see cref="Vehicle"/>) set
/// <see cref="Persistent"/> so Position/Heading/Health/ModelName fall back to it when
/// unspawned, instead of every subclass re-implementing that fallback itself.
/// </summary>
public abstract class Entity : ISaveableEntity, IEquatable<Entity>
{
    protected INativeEntity? Native { get; set; }
    private protected PersistentEntity? Persistent { get; set; }

    public string Id { get; } = "";
    public bool IsSpawned => Native != null;
    public int Handle => Native?.Handle ?? 0;

    public virtual Vector3 Position
    {
        get => Native?.Position ?? Persistent?.Position ?? default;
        set
        {
            if (Persistent != null)
                Persistent.Position = value;
            if (Native != null)
                Native.Position = value;
        }
    }
    public virtual float Heading
    {
        get => Native?.Heading ?? Persistent?.Heading ?? default;
        set
        {
            if (Persistent != null)
                Persistent.Heading = value;
            if (Native != null)
                Native.Heading = value;
        }
    }
    public virtual int Health
    {
        get => Native?.Health ?? Persistent?.Health ?? default;
        set
        {
            if (Persistent != null)
                Persistent.Health = value;
            if (Native != null)
                Native.Health = value;
        }
    }
    public virtual string ModelName => Native?.ModelName ?? Persistent?.ModelName ?? string.Empty;

    public bool Equals(Entity other)
    {
        if (other is null) return false;
        return Id == other.Id;
    }

    public override bool Equals(object obj) => obj is Entity e && Equals(e);
    public override int GetHashCode() => Id.GetHashCode();
}
