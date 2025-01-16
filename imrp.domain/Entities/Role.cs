
namespace imrp.domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<RoleClaim> RoleClaims { get; set; } = [];
        public List<UserRole> UserRoles { get; set; } = [];

        public Role(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public void AddClaim(Claim claim)
        {
            Claims.Add(claim);
        }

        public void RemoveClaim(Claim claim)
        {
            Claims.Remove(claim);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }
    }
}
