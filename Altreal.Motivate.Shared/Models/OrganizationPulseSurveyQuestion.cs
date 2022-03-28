namespace Altreal.Motivate.Shared.Models
{
    public class OrganizationPulseSurveyQuestion : BaseEntity
    {
        public virtual Organization Organization { get; set; }
        public virtual Behavior Behavior { get; set; }
        public string QuestionKey { get; set; }
        public string CustomQuestion { get; set; }
        public int Sort { get; set; }
    }
}