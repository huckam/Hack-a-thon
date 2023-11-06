using System.ComponentModel.DataAnnotations;

namespace ECTPFinalProject.Core.Entities
{
    public class Event
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public EventType Type { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}