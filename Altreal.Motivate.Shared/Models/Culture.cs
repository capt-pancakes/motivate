namespace Altreal.Motivate.Shared.Models
{
    public class Culture : BaseEntity
    {
        public string Code { get; set; }
        public bool Enabled { get; set; }
        public string EnglishName { get; set; }
        public string NameKey { get; set; }
    }
}