namespace Altreal.Motivate.Shared.Models
{
    public class PulseSurveyBehaviorResult : BaseEntity
    {
        public virtual PulseSurveyResult PulseSurveyResult { get; set; }
        public virtual Behavior Behavior { get; set; }
        public int Score { get; set; }
        public string AdditionalComments { get; set; }
    }
}