namespace Altreal.Motivate.Shared.Models
{
    public class Timezone : BaseEntity
    {
        public string OffsetLabel { get; set; }
        public double Offset { get; set; }
        public string Description { get; set; }
    }
}
