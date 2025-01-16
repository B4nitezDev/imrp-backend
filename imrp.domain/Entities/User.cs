namespace imrp.domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Password_after { get; set; }
        public string Password_salt { get; set; }
        public List<UserRole> UserRoles { get; set; } = [];
        public List<Report> Reports { get; set; } = [];
        public List<InventoryMovement> InventoryMovement { get; set; } = [];

    }
}
