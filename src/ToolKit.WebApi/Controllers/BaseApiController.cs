using Microsoft.AspNetCore.Mvc;

namespace ToolKit.WebApi.Controllers;

[ApiController]
[Route("api/ToolKit/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    [NonAction]
    public virtual JsonResult JsonResponse(string message, int statusCode = 200)
        => new(message) { StatusCode = statusCode };

    [NonAction]
    public virtual JsonResult JsonResponse<T>(T data, int statusCode = 200)
        where T : class
        => new(new ResponseData<T> { Data = data }) { StatusCode = statusCode };
    
    [NonAction]
    public virtual JsonResult JsonResponse<T>(T data, string message, int statusCode = 200)
        where T : class
        => new(new ResponseData<T> { Data = data, Message = message }) { StatusCode = statusCode };

    [NonAction]
    protected string GetAccessTokenFromHeader()
    {
        this.HttpContext.Request.Headers.TryGetValue("Authorization", out var token);
        var accessToken = token.ToString().Replace("Bearer", string.Empty, StringComparison.OrdinalIgnoreCase).Trim();
        return accessToken;
    }
    
    public class ResponseData<T> where T : class
    {
        public string? Message { get; set; }
        public T? Data { get; set; }
    }
}