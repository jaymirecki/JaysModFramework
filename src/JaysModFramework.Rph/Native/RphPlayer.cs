using JaysModFramework.Core.Native;
using JaysModFramework.Core.World;
using Rage;
using RagePlayer = Rage.Player;
using Vector3 = JaysModFramework.Core.Vector3;

namespace JaysModFramework.Rph.Native;

internal sealed class RphPlayer : INativePlayer
{
    private readonly RagePlayer _player;

    internal RphPlayer(RagePlayer player) => _player = player;

    public INativePed Character => new RphPed(_player.Character);

    public string Model
    {
        get => _player.Character.Model.Name;
    }

    public void SetModel(string modelName)
    {
        var model = new Model(modelName);
        model.LoadAndWait();
        _player.Model = model;
    }

    public Vector3 Position
    {
        get
        {
            var pos = _player.Character.Position;
            return new Vector3(pos.X, pos.Y, pos.Z);
        }
        set => _player.Character.Position = new Rage.Vector3(value.X, value.Y, value.Z);
    }

    public float Heading
    {
        get => _player.Character.Heading;
        set => _player.Character.Heading = value;
    }

    public int Health
    {
        get => _player.Character.Health;
        set => _player.Character.Health = value;
    }

    public int Armor
    {
        get => _player.Character.Armor;
        set => _player.Character.Armor = value;
    }
}
