using JaysModFramework.Core.Game;
using JaysModFramework.Core.Plugins;
using JaysModFramework.Core.UI;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core.Plugins.Sirens;

public class SirenManagerPlugin : IMenuPlugin
{
    private GameServices _game;
    private IGameWorld _world;
    private bool _hasVehicle;
    private IVehicle _currentVehicle = null;
    private SirenState _currentSirenState = SirenState.Off;
    private MenuItem _modeLabel;
    private Menu _menu;

    public string Name => "Siren Manager";

    public void Initialize(IFrameworkServices services)
    {
        _game = services.Game;
        _world = services.World;
        _hasVehicle = false;

        _modeLabel = new MenuItem
        {
            Title = ModeTitle(null),
            Description = "Current siren mode. Use the siren cycle key to change.",
            Enabled = false,
        };

        var cycleItem = new MenuItem
        {
            Title = "Cycle Mode",
            Description = "Advance to the next siren mode.",
        };
        cycleItem.OnActivated += CycleMode;

        _menu = services.Game.MenuService.CreateMenu("JMF", "Siren Manager");
        _menu.Add(_modeLabel);
        _menu.Add(cycleItem);

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
        if (!Equals(vehicle, _currentVehicle))
        {
            _currentVehicle = vehicle;
            var inVehicle = vehicle != null && vehicle.HasSirens;
            if (vehicle == null) {
                _game.Logger.Debug($"Leaving siren vehicle");
            }
            else {
                _currentSirenState = vehicle.SirenState;
                _game.Logger.Debug($"Entered siren vehicle, current state: {_currentSirenState}");
            }
            _hasVehicle = inVehicle;
            UpdateLabel(vehicle);
        }
    }

    private void OnControlClicked(JmfControl control)
    {
        if (control != JmfControl.SirenCycle) return;
        var vehicle = _world.GetPlayerVehicle();
        if (vehicle == null || !vehicle.HasSirens) return;
        CycleMode(vehicle);
    }

    private void CycleMode()
    {
        var vehicle = _world.GetPlayerVehicle();
        if (vehicle == null || !vehicle.HasSirens) return;
        CycleMode(vehicle);
    }

    private void CycleMode(IVehicle vehicle)
    {
        var previous = _currentSirenState;
        var next = previous switch
        {
            SirenState.Off        => SirenState.On,
            SirenState.On         => SirenState.LightsOnly,
            SirenState.LightsOnly => SirenState.Off,
            _                     => SirenState.Off,
        };
        vehicle.SirenState = next;
        _game.Logger.Debug(
            $"Siren: {previous} → {next} " +
            $"(lights: {LightsState(previous)}→{LightsState(next)}, " +
            $"sound: {SoundState(previous)}→{SoundState(next)})");
        _currentSirenState = next;
        UpdateLabel(vehicle);
    }

    private static string LightsState(SirenState state) => state == SirenState.Off ? "off" : "on";
    private static string SoundState(SirenState state) => state == SirenState.On ? "on" : "off";

    private void UpdateLabel(IVehicle vehicle)
    {
        _modeLabel.Title = ModeTitle(vehicle);
        if (_game.MenuService.IsVisible)
            _game.MenuService.RefreshMenu();
    }

    private static string ModeTitle(IVehicle vehicle)
    {
        if (vehicle == null) return "Mode: N/A";
        return $"Mode: {vehicle.SirenState}";
    }
}
