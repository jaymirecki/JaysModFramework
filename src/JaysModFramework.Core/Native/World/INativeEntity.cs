using System;

namespace JaysModFramework.Core.Native;

public interface INativeEntity : IEquatable<INativeEntity>
{
    Vector3 Position { get; }
    float Heading { get; }
    string ModelName { get; }
    int Handle { get; }
}
