using imrp.application.Dto;
using imrp.application.Interfaces;
using imrp.application.Result;
using imrp.domain.Entities;
using imrp.domain.Interfaces;

namespace imrp.application.Services
{
    public class UserServices (IRepository<User> userRepository, ILoggerService logger, IMapperService<User, UserDto> userMapper)
    {
        private readonly IRepository<User> _userRepository = userRepository;
        private readonly ILoggerService _loggerService = logger;
        private readonly IMapperService<User, UserDto> _userMapper = userMapper;

        public Result.Result<UserDto> Add(UserDto dto)
        {
            _loggerService.LogInformation($"Usuario a agregar: {dto}");
            
            if (ValidateUser(dto, out var result)) return result;

            var newUser = _userMapper.MapBack(dto);

            newUser.Password_after = dto.Password;
            newUser.Password_salt = "salt";
            
            var user = _userRepository.Add(newUser);
            _userRepository.SaveChanges();
            
            return Result.Result<UserDto>.Success(_userMapper.Map(user));
        }
        
        public Result.Result<User> Login(LoginUserDto userDto)
        {
            var query = _userRepository.IQueryable();
            
            query = query.Where(x => x.Email == userDto.Email);

            User? user = query.FirstOrDefault();
            
            if(user == null)
            {
                return Result.Result<User>.Failure("Usuario no encontrado");
            }
            
            // TODO: Validar si es un password hash

            if(user.Password_after != userDto.Password)
            {
                return Result.Result<User>.Failure("Contraseña incorrecta");
            }

            return Result.Result<User>.Success(user);
        }

        private bool ValidateUser(UserDto dto, out Result<UserDto> result)
        {
            var query = _userRepository.IQueryable();
            
            query = query.Where(x => x.Email == dto.Email);

            User? existinguser = query.FirstOrDefault();
            
            if(existinguser != null)
            {
                result = Result.Result<UserDto>.Failure("El usuario ya existe");
                return true;
            }

            result = null;
            return false;
        }
    }
}
