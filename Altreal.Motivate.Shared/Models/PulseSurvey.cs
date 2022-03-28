using System.ComponentModel.DataAnnotations.Schema;

namespace Altreal.Motivate.Shared.Models
{
    public class PulseSurvey : BaseEntity
    {
        public virtual ActionPlan ActionPlan { get; set; }
        public virtual List<PulseSurveyResult> Results { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime? DueAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public Guid UserId { get; set; }
        public int Cycle { get; set; }
        //public virtual List<AdditionalPulseSurveyQuestion> AdditionalQuestions { get; set; }


        [NotMapped]
        public List<PulseSurveyResult> OpenResults => this.Results != null && this.Results.Any()
            ? this.Results.Where(r => !r.CompletedAt.HasValue && !r.DeletedAt.HasValue).ToList()
            : null;

        [NotMapped]
        public List<PulseSurveyResult> CompletedResults => this.Results != null && this.Results.Any()
            ? this.Results.Where(r => r.CompletedAt.HasValue && !r.DeletedAt.HasValue).ToList()
            : null;

        [NotMapped]
        public bool CanViewResults => this.Results != null && this.Results.Any() && this.Results.Count(r => r.CompletedAt.HasValue) >= 3;

        [NotMapped] public bool IsComplete => this.CompletedAt.HasValue;

        [NotMapped]
        public List<Statistic> Statistics =>
            this.CompletedResults != null && this.CompletedResults.Any() ? Statistic.Build(this.CompletedResults) : null;

    }
}