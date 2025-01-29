using imrp.persistence.Database;

namespace imrp_backend.Middlewares;

public class AuthMiddleware
{
    private readonly RequestDelegate _next;

    public AuthMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task Invoke(HttpContext context)
    {
        string? token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        if (token != null)
        {
            AttachUserToContext(context, token);
        }
        
        await _next(context);
    }

    private void AttachUserToContext(HttpContext context, string token)
    {
        // TODO: Implementar
        throw new NotImplementedException();
    }
}