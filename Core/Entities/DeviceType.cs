using System.ComponentModel.DataAnnotations;

namespace LinkHub.Core.Entities;

public class DeviceType
{
    public Guid Id { get; set; }

    [Required]
    [MaxLength(128)]
    public string Name { get; set; }
}