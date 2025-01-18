using imrp.application.Dto;
using imrp.application.Interfaces.UseCases.User;
using imrp.application.Result;
using Microsoft.AspNetCore.Mvc;

namespace imrp_backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IAddUserUseCase addUserUseCase) : ControllerBase
{
    private IAddUserUseCase _addUserUseCase = addUserUseCase;

    [HttpPost]
    public IActionResult AddUser(UserDto userDto)
    {
        var result = _addUserUseCase.Execute(userDto);
        return Ok(result.Value);
    }
}