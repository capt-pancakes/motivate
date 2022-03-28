namespace Altreal.Motivate.Shared.Models
{
    public class JournalMedia : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Path { get; set; }
        public string Filename { get; set; }
        public int Size { get; set; }
        public MediaType FileType { get; set; }
    }
}