using JaysModFramework.Core.World;
using Rage;
using Vector3 = JaysModFramework.Core.Vector3;

namespace JaysModFramework.Rph.Native;

internal abstract class RphEntity : IEntity
{
    private readonly Entity _entity;

    protected RphEntity(Entity entity) => _entity = entity;

    public Vector3 Position => new Vector3(_entity.Position.X, _entity.Position.Y, _entity.Position.Z);
    public float Heading => _entity.Heading;
    public string ModelName => _entity.Model.Name;

    public bool Equals(IEntity other) => other is RphEntity rph && _entity == rph._entity;
    public override bool Equals(object obj) => obj is IEntity e && Equals(e);
    public override int GetHashCode() => _entity.GetHashCode();
}
