namespace Altreal.Motivate.Shared.Models
{
    public class Behavior : BaseEntity
    {
        public string NameKey { get; set; }
        public string ReportTextKey { get; set; }
        public string RatingFeedbackQuestionKey { get; set; }
        public string AdditionalFeedbackQuestionKey { get; set; }
        public string LowLabelKey { get; set; }
        public string HighLabelKey { get; set; }
        public virtual BehaviorGroup BehaviorGroup { get; set; }
        public int Order { get; set; }
    }
}