
namespace imrp.domain.Entities
{
    public class Claim(string name, string description): BaseEntity
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public List<RoleClaim> RoleClaims { get; set; } = [];
    }
}
