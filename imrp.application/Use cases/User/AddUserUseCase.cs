using imrp.application.Dto;
using imrp.application.Services;

namespace imrp.application.Use_cases.User;

public class AddUserUseCase(UserServices userServices)
{
    private readonly UserServices _userServices = userServices;
    
    public Result.Result<UserDto> Execute(UserDto userDto)
    {
        // TODO: add password hashing
        return _userServices.Add(userDto);
    }
}