using JaysModFramework.Core.World;
using RageEntity = Rage.Entity;
using Vector3 = JaysModFramework.Core.Vector3;

namespace JaysModFramework.Rph.Native;

internal abstract class RphEntity : INativeEntity
{
    private readonly RageEntity _entity;

    protected RphEntity(RageEntity entity) => _entity = entity;

    public Vector3 Position => new Vector3(_entity.Position.X, _entity.Position.Y, _entity.Position.Z);
    public float Heading => _entity.Heading;
    public string ModelName => _entity.Model.Name;
    public int Handle => (int)_entity.Handle.Value;

    public bool Equals(INativeEntity other) => other is RphEntity rph && _entity == rph._entity;
    public override bool Equals(object obj) => obj is INativeEntity e && Equals(e);
    public override int GetHashCode() => _entity.GetHashCode();
}
