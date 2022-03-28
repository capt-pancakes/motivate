using System.ComponentModel.DataAnnotations.Schema;

namespace Altreal.Motivate.Shared.Models
{
    public class ActionPlan : BaseEntity
    {
        public virtual List<ActionPlanReminder>? ActionPlanReminders { get; set; }
        public List<ActionPlanBehavior>? Behaviors { get; set; }
        public virtual List<ActionPlanActionStep>? ActionSteps { get; set; }
        public virtual List<ActionGoal>? Goals { get; set; }
        public virtual List<PulseSurvey>? PulseSurveys { get; set; }
        public string? CalendarUrl { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public string? Failures { get; set; }
        public string? Helpful { get; set; }
        public bool IsCalendarized { get; set; }
        public string? Label { get; set; }
        public string? Name { get; set; }
        public string? NextFocus { get; set; }
        public DateTime? StartsAt { get; set; }
        public string? Success { get; set; }
        public Guid UserId { get; set; }
        public bool IsFocusPlan { get; set; }
        public DateTime? PlanInitiatedAt { get; set; }

        #region Computed Properties

        [NotMapped]
        public string Status { get; set; }

        [NotMapped]
        public int DaysRemaining => this.EndsAt?.Subtract(DateTime.UtcNow).Days ?? 0;

        [NotMapped]
        public int TotalDays => this.EndsAt.HasValue && this.StartsAt.HasValue ? this.EndsAt.Value.Subtract(this.StartsAt.Value).Days : 0;

        [NotMapped]
        public bool CanBeCompleted => this.CompletedAt.HasValue == false && this.Behaviors != null && this.Behaviors.All(b => b.ActionSteps?.All(a => a.CompletedAt.HasValue) ?? false);

        [NotMapped]
        public bool CanBeDeleted => this.CompletedAt.HasValue == false && this.Behaviors != null && this.Behaviors.All(b => b.ActionSteps?.All(a => a.CompletedAt.HasValue) ?? false) && !this.PulseSurveys.Any();

        [NotMapped]
        public bool CanCreatePulseSurvey => this.PulseSurveys != null && this.PulseSurveys.All(ps => ps.CompletedAt.HasValue) && this.CompletedAt.HasValue == false;

        [NotMapped]
        public bool CanEditBehavior => this.PulseSurveys != null && !this.PulseSurveys.Any();

        [NotMapped]
        public PulseSurvey? CurrentPulseSurvey => PulseSurveys?.OrderByDescending(ps => ps.Cycle).FirstOrDefault();

        //[NotMapped]
        //public int ProgressPercent => 
        //    this.Behaviors != null &&
        //    this.Behaviors.Any() &&  
        //    this.Behaviors.SelectMany(b => b.ActionSteps).Any()
        //        ? ((this.ActionStepsComplete?.Count ?? 0) / this.Behaviors.SelectMany(b => b.ActionSteps).Count()) * 100
        //        : 0;

        [NotMapped]
        public int TimelinePercent =>
            this.EndsAt.HasValue && this.StartsAt.HasValue
                ? this.TotalDays > 0 ? (this.DaysRemaining / this.TotalDays) * 100 
                : 0
                : 0;

        //[NotMapped]
        //public virtual List<ActionPlanActionStep>? ActionStepsComplete => Behaviors?.SelectMany(b => b.ActionSteps)?.Where(step => (step?.CompletedAt.HasValue ?? false)).ToList();

        [NotMapped]
        public bool IsComplete => this.CompletedAt.HasValue;

        [NotMapped]
        public virtual List<PulseSurveyResult>? PulseSurveyResults => this.PulseSurveys?.SelectMany(survey => survey.Results).ToList();

        [NotMapped]
        public virtual List<ActionPlanActionStep>? AllActionSteps => this.Behaviors != null && this.Behaviors.Any()
            ? this.Behaviors.Any(b => b.ActionSteps != null && b.ActionSteps.Any()) ? this.Behaviors.SelectMany(b => b.ActionSteps).ToList()
            : null : null;

        [NotMapped]
        public virtual List<PulseSurvey>? CompletedPulseSurveys => this.PulseSurveys != null && this.PulseSurveys.Any()
            ? this.PulseSurveys.Where(ps => ps.IsComplete).ToList()
            : null;

        #endregion

    }

}