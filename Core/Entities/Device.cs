using LinkHub.Core.Types;

namespace LinkHub.Core.Entities;

public class Device
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public DeviceType Type { get; set; }
    public DeviceStatus Status { get; set; }
}