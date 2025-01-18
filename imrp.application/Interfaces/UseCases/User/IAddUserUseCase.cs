using imrp.application.Dto;

namespace imrp.application.Interfaces.UseCases.User;

public interface IAddUserUseCase
{
    Result.Result<UserDto> Execute(UserDto userDto);
}