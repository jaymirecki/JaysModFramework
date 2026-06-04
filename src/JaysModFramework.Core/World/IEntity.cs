using System;

namespace JaysModFramework.Core.World;

public interface IEntity : IEquatable<IEntity>
{
    Vector3 Position { get; }
    float Heading { get; }
    string ModelName { get; }
}
