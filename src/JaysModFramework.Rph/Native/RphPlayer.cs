using JaysModFramework.Core.Native;
using Rage;
using RagePlayer = Rage.Player;

namespace JaysModFramework.Rph.Native;

internal sealed class RphPlayer : INativePlayer
{
    private readonly RagePlayer _player;

    internal RphPlayer(RagePlayer player) => _player = player;

    public INativePed Ped => new RphPed(_player.Character);

    public string Model => _player.Character.Model.Name;

    public void SetModel(string modelName)
    {
        var model = new Model(modelName);
        model.LoadAndWait();
        _player.Model = model;
    }
}
