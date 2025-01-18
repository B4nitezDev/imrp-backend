using imrp.domain.Entities;

namespace imrp.application.Dto
{
    public class UserDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Password_after { get; set; } = string.Empty;
        public int Password_salt { get; set; }
        public List<UserRole>? UserRoles { get; set; }
        public List<Report>? Reports { get; set; }
        public List<InventoryMovement>? InventoryMovement { get; set; }
    }
}
