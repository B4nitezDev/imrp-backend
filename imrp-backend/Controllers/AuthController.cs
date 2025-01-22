using imrp.application.Interfaces.UseCases.Auth;
using imrp.persistence.Jwt;
using Microsoft.AspNetCore.Mvc;

namespace imrp_backend.Controllers;

    [ApiController]
    [Route("api/[controller]")]
public class AuthController: ControllerBase
{
        private readonly ILogger<AuthController> _logger;
        private readonly JwtTokenService _tokenService;
        private readonly ILoginUseCase _loginUseCase;
        
        public AuthController(JwtTokenService tokenService, ILogger<AuthController> logger, ILoginUseCase loginUseCase)
        {
            _tokenService = tokenService;
            _logger = logger;
            _loginUseCase = loginUseCase;
        }

        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            _logger.LogInformation($"Intento de login de {username}");
            
            if(username == null || password == null)
                return BadRequest("Faltan datos");
            
            var result = _loginUseCase.Execute(username, password);
            
            if(!result.IsSuccess)
                return Unauthorized(result.Message);
            
            // TODO: Sacar role de la base de datos
            var token = _tokenService.GenerateToken(result.Value.Id.ToString(), "Admin");
            return Ok(new { Token = token });
                
        }
}