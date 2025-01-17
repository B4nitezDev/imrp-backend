
namespace imrp.domain.Entities
{
    public class RoleClaim: BaseEntity
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int ClaimId { get; set; }
        public Claim Claim { get; set; }
    }
}
