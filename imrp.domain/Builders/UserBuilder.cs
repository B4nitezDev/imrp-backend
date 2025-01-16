using imrp.domain.Entities;

namespace imrp.domain.Builders
{
    public class UserBuilder
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _passwordAfter;
        private string _passwordSalt;
        private List<UserRole> _roles = [];
        private List<Report> _reports = [];
        private List<InventoryMovement> _inventoryMovement = [];    

        public UserBuilder WithId(int id)
        {
            _id = id;
            return this;
        }

        public UserBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public UserBuilder WithEmail(string email)
        {
            _email = email;
            return this;
        }

        public UserBuilder WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public UserBuilder WithPasswordAfter(string passwordAfter)
        {
            _passwordAfter = passwordAfter;
            return this;
        }

        public UserBuilder WithPasswordSalt(string passwordSalt)
        {
            _passwordSalt = passwordSalt;
            return this;
        }

        public UserBuilder AddRole(UserRole role)
        {
            _roles.Add(role);
            return this;
        }

        public UserBuilder AddReport(Report report)
        {
            _reports.Add(report);
            return this;
        }

        public UserBuilder AddInventoryMovement(InventoryMovement inventoryMovement)
        {
            _inventoryMovement.Add(inventoryMovement);
            return this;
        }

        public User Build()
        {
            return new User()
            {
                Id = _id,
                Name = _name,
                Email = _email,
                Password = _password,
                Password_after = _passwordAfter,
                Password_salt = _passwordSalt,
                UserRoles = _roles,
                Reports = _reports,
                InventoryMovement = _inventoryMovement
            };
        }
    }
}
