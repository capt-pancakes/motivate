namespace Altreal.Motivate.Shared.Models
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public virtual List<OrganizationGoal> Goals { get; set; }
    }
}