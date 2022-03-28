namespace Altreal.Motivate.Shared.Models
{
    public class PulseSurveyQuestion : BaseEntity
    {
        public virtual PulseSurvey PulseSurvey { get; set; }
        public virtual OrganizationPulseSurveyQuestion OrganizationPulseSurveyQuestion { get; set; }
        public virtual Behavior Behavior { get; set; }
        public string CustomQuestion { get; set; }
        public int Sort { get; set; }
    }
}