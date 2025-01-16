
namespace imrp.domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<RoleClaim> RoleClaims { get; set; } = [];
        public virtual List<UserRole> UserRoles { get; set; } = [];

        public Role(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public void AddClaim(RoleClaim claim)
        {
            RoleClaims.Add(claim);
        }

        public void RemoveClaim(RoleClaim claim)
        {
            RoleClaims.Remove(claim);
        }

        public void AddUser(UserRole user)
        {
            UserRoles.Add(user);
        }

        public void RemoveUser(UserRole user)
        {
            UserRoles.Remove(user);
        }
    }
}
