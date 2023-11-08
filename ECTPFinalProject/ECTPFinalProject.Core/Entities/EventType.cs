using System.ComponentModel.DataAnnotations;

namespace ECTPFinalProject.Core.Entities;

public class EventType
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }

    public string Description { get; set; }
}