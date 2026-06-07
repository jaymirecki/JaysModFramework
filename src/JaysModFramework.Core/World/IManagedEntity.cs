using System;

namespace JaysModFramework.Core.World;

/// <summary>
/// A framework-managed entity. Superset of <see cref="INativeEntity"/> — carries all
/// the same observable properties plus stable identity and spawn state. Does not extend
/// <see cref="INativeEntity"/> so that the native and managed interface hierarchies remain
/// independent; the concrete <see cref="Entity"/> class bridges them internally.
/// </summary>
public interface IManagedEntity : IEquatable<IManagedEntity>
{
    Guid Id { get; }
    bool IsSpawned { get; }

    // Mirror of INativeEntity properties — always readable whether or not spawned.
    Vector3 Position { get; }
    float Heading { get; }
    string ModelName { get; }
    int Handle { get; }
}
