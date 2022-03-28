using System.ComponentModel.DataAnnotations.Schema;

namespace Altreal.Motivate.Shared.Models
{
    public class Observer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual Culture Culture { get; set; }
        public Guid UserId { get; set; }
        public ObserverType Type { get; set; }
        public bool Disabled { get; set; }

        [NotMapped] public string FullName => this.FirstName + " " + this.LastName;

    }
}