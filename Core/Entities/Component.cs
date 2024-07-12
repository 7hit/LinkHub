using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkHub.Core.Entities;

[Table("Components")]
public class Component : Base
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }
}