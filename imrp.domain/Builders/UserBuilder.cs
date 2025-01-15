using imrp.domain.Entities;

namespace imrp.domain.Builders
{
    public class UserBuilder
    {
        private User _user = new User();

        public UserBuilder WithId(int id)
        {
            _user.Id = id;
            return this;
        }

        public UserBuilder WithName(string name)
        {
            _user.Name = name;
            return this;
        }

        public UserBuilder WithEmail(string email)
        {
            _user.Email = email;
            return this;
        }

        public UserBuilder WithPassword(string password)
        {
            _user.Password = password;
            return this;
        }

        public UserBuilder WithPasswordAfter(string passwordAfter)
        {
            _user.Password_after = passwordAfter;
            return this;
        }

        public UserBuilder WithPasswordSalt(string passwordSalt)
        {
            _user.Password_salt = passwordSalt;
            return this;
        }

        public UserBuilder AddRole(Role role)
        {
            _user.Roles.Add(role);
            return this;
        }

        public UserBuilder AddReport(Report report)
        {
            _user.Reports.Add(report);
            return this;
        }

        public UserBuilder AddInventoryMovement(InventoryMovement inventoryMovement)
        {
            _user.InventoryMovement.Add(inventoryMovement);
            return this;
        }

        public User Build()
        {
            return _user;
        }
    }
}
