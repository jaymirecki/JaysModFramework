namespace JaysModFramework.Core.World;

/// <summary>
/// Extends <see cref="ISaveableEntity"/> with vehicle-specific persistable properties.
/// Implemented by both <see cref="PersistentVehicle"/> (serialised backing store) and
/// the live <see cref="Vehicle"/> wrapper, so either can be passed to any code that
/// only needs to read or write vehicle data without caring about spawn state.
/// </summary>
public interface ISaveableVehicle : ISaveableEntity
{
    bool HasSirens { get; }
    SirenState SirenState { get; set; }
}
