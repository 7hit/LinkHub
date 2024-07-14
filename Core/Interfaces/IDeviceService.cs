using LinkHub.Core.Entities;

namespace LinkHub.Core.Interfaces;

public interface IDeviceService
{
    public Device GetDevice(Guid id);
    public void CreateDevice(Device device);
    public Device UpdateDevice(Guid id, Device device);
    public void DeleteDevice(Guid id);
}