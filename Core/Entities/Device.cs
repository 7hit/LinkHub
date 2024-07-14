#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace LinkHub.Core.Entities;

public class Device
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DeviceType Type { get; set; }
    public string Location { get; set; }
    public string Status { get; set; }
    public List<Block> Blocks { get; set; }
    public DeviceOptions Options { get; set; }
}