using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace JaysModFramework.Core.Models;

public class VehicleModelRepository
{
    private readonly List<VehicleModelDefinition> _models;

    public VehicleModelRepository(string gameDirectory)
    {
        var dir = Path.Combine(gameDirectory, "JMF", "Data", "Models", "Vehicles");
        _models = Directory.Exists(dir)
            ? Directory.GetFiles(dir, "*.xml").Select(LoadFile).ToList()
            : new List<VehicleModelDefinition>();
    }

    /// <summary>Sorted list of all vehicle class names found in the catalog.</summary>
    public IReadOnlyList<string> Classes =>
        _models.Select(m => m.Class).Distinct().OrderBy(c => c).ToList();

    /// <summary>All vehicle definitions for a given class, sorted by display name.</summary>
    public IReadOnlyList<VehicleModelDefinition> GetByClass(string className) =>
        _models.Where(m => m.Class == className).OrderBy(m => m.Name).ToList();

    private static VehicleModelDefinition LoadFile(string path)
    {
        var root = XDocument.Load(path).Root;
        return new VehicleModelDefinition
        {
            Name = root?.Element("Name")?.Value ?? string.Empty,
            ModelName = root?.Element("ModelName")?.Value ?? string.Empty,
            Class = root?.Element("Class")?.Value ?? string.Empty,
        };
    }
}
