using imrp.domain.Entities;

namespace imrp.application.Dto
{
    public class UserDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<UserRole>? UserRoles { get; set; }
    }
}
