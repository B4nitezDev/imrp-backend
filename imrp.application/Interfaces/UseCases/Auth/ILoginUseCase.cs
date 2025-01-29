using imrp.application.Dto;

namespace imrp.application.Interfaces.UseCases.Auth;

public interface ILoginUseCase
{
    public Result.Result<domain.Entities.User> Execute(LoginUserDto userDto);
}