using imrp.application.Dto;
using imrp.application.Interfaces.UseCases.Auth;
using imrp.application.Result;
using imrp.application.Services;

namespace imrp.application.Use_cases.Auth;

public class LoginUseCase(UserServices userServices): ILoginUseCase
{
    private readonly UserServices _userServices = userServices;
    
    public Result.Result<domain.Entities.User> Execute(LoginUserDto userDto)
    {
        return _userServices.Login(userDto);
    }
}