using System.ComponentModel.DataAnnotations.Schema;

namespace Altreal.Motivate.Shared.Models
{
    public class PulseSurveyResult : BaseEntity
    {
        public string ShareCode { get; set; }
        public int RemindersSent { get; set; }
        public virtual PulseSurvey PulseSurvey { get; set; }
        public virtual Observer Observer { get; set; }
        public DateTime? CompletedAt { get; set; }
        public virtual List<PulseSurveyBehaviorResult> Results { get; set; }
        public virtual ActionPlan ActionPlan { get; set; }

        [NotMapped] public string Status => this.CompletedAt.HasValue ? "Completed" : "Open";
    }
}