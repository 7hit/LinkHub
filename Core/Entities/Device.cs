using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace LinkHub.Core.Entities;

public class Device
{
    public Guid Id { get; set; }

    [Required]
    [MaxLength(32)]
    public string Name { get; set; }

    [Required]
    public DeviceType Type { get; set; }

    public string? Location { get; set; }

    public List<Block>? Blocks { get; set; }

    public DeviceOptions? Options { get; set; }
}