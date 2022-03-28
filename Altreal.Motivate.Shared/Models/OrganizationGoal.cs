namespace Altreal.Motivate.Shared.Models
{
    public class OrganizationGoal : BaseEntity
    {
        public virtual Organization Organization { get; set; }
        public string QuestionKey { get; set; }
        public GoalType Type { get; set; }
        public int Sort { get; set; }
    }
}