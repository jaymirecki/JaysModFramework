using JaysModFramework.Core.Game;
using JaysModFramework.Core.Plugins;
using JaysModFramework.Core.UI;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core.Plugins.Sirens;

public class SirenManagerPlugin : IMenuPlugin
{
    private GameServices _game;
    private IGameWorld _world;
    private IVehicle _currentVehicle;
    private SirenState _sirenState = SirenState.Off;
    private MenuListItem<SirenState> _sirenListItem;
    private Menu _menu;

    public string Name => "Siren Manager";

    public void Initialize(IFrameworkServices services)
    {
        _game = services.Game;
        _world = services.World;

        _sirenListItem = new MenuListItem<SirenState>(new[] { SirenState.Off, SirenState.On, SirenState.LightsOnly })
        {
            Title = "Mode",
            Description = "Current siren mode. Use the siren cycle key or left/right to change.",
            Enabled = false,
        };
        _sirenListItem.OnItemChanged += OnSirenItemChanged;

        _menu = services.Game.MenuService.CreateMenu("JMF", "Siren Manager");
        _menu.Add(_sirenListItem);

        _game.Lifecycle.Tick += OnTick;
        _game.Lifecycle.ControlClicked += OnControlClicked;
    }

    public Menu GetMenu() => _menu;

    public void Shutdown()
    {
        _game.Lifecycle.Tick -= OnTick;
        _game.Lifecycle.ControlClicked -= OnControlClicked;
    }

    private void OnTick()
    {
        var vehicle = _world.GetPlayerVehicle();
        if (Equals(vehicle, _currentVehicle)) return;

        _currentVehicle = vehicle;
        var hasSirens = vehicle != null && vehicle.HasSirens;
        _sirenListItem.Enabled = hasSirens;

        if (hasSirens)
        {
            SetSirenState(vehicle.SirenState);
            _game.Logger.Debug($"Entered siren vehicle, current state: {_sirenState}");
        }
        else
        {
            SetSirenState(SirenState.Off);
            if (vehicle == null)
                _game.Logger.Debug("Leaving siren vehicle");
        }

        if (_game.MenuService.IsVisible)
            _game.MenuService.RefreshMenu();
    }

    private void OnControlClicked(JmfControl control)
    {
        if (control != JmfControl.SirenCycle) return;
        var vehicle = _currentVehicle;
        if (vehicle == null || !vehicle.HasSirens) return;

        var next = _sirenState switch
        {
            SirenState.Off        => SirenState.On,
            SirenState.On         => SirenState.LightsOnly,
            SirenState.LightsOnly => SirenState.Off,
            _                     => SirenState.Off,
        };
        SetSirenState(next);
        ApplyState(vehicle);
    }

    private void OnSirenItemChanged(SirenState state)
    {
        var vehicle = _currentVehicle;
        if (vehicle == null || !vehicle.HasSirens) return;
        _sirenState = state;
        ApplyState(vehicle);
    }

    private void SetSirenState(SirenState state)
    {
        _sirenState = state;
        _sirenListItem.SelectedIndex = (int)_sirenState;
    }

    private void ApplyState(IVehicle vehicle)
    {
        var previous = vehicle.SirenState;
        vehicle.SirenState = _sirenState;
        _game.Logger.Debug(
            $"Siren: {previous} → {_sirenState} " +
            $"(lights: {LightsState(previous)}→{LightsState(_sirenState)}, " +
            $"sound: {SoundState(previous)}→{SoundState(_sirenState)})");

        if (_game.MenuService.IsVisible)
            _game.MenuService.RefreshMenu();
    }

    private static string LightsState(SirenState state) => state == SirenState.Off ? "off" : "on";
    private static string SoundState(SirenState state) => state == SirenState.On ? "on" : "off";
}
