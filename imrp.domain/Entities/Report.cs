
namespace imrp.domain.Entities
{
    public class Report: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
