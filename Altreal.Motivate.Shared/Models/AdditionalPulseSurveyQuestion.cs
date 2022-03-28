namespace Altreal.Motivate.Shared.Models
{
    public class AdditionalPulseSurveyQuestion : BaseEntity
    {
        public OrganizationPulseSurveyQuestion Question { get; set; }
        public string Response { get; set; }
    }
}