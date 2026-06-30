using System;

namespace JaysModFramework.Core.Native;

public interface INativeEntity : IEquatable<INativeEntity>
{
    Vector3 Position { get; set; }
    float Heading { get; set; }
    string ModelName { get; }
    int Handle { get; }
    int Health { get; set; }
}
