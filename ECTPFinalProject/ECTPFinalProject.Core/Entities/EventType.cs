using System.ComponentModel.DataAnnotations;

namespace ECTPFinalProject.Core.Entities;

public class EventType
{
    [Required]
    public string Name { get; set; }

    public string Description { get; set; }
}