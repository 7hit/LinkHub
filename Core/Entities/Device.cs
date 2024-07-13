using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LinkHub.Core.Types;

namespace LinkHub.Core.Entities;

[Table("Devices")]
public class Device : Base
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public DeviceType Type { get; set; }
    
    public string Location { get; set; }
    
    public DeviceStatus Status { get; set; }
    
    public List<Block> Components { get; set; }
}