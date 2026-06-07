using System;

namespace JaysModFramework.Core.World;

public interface IManagedEntity : INativeEntity
{
    Guid Id { get; }
    bool IsSpawned { get; }
}
