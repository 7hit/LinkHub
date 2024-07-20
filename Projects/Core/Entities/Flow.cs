using System.ComponentModel.DataAnnotations;

namespace LinkHub.Core.Entities;

public class Flow
{
    public Guid Id { get; set; }

    [Required] [MaxLength(32)] public string Name { get; set; }

    [Required] [MaxLength(256)] public string Description { get; set; }
}