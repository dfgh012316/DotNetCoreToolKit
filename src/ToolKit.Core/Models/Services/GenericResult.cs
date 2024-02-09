using System.Net;

namespace ToolKit.Core.Services;

public class GenericResult
{
    public GenericResult()
    {

    }

    public GenericResult(int statusCode, string? message =null)
    {
        StatusCode = statusCode;
        message = message ?? message;
    }

    public int StatusCode { get; set; } = (int)HttpStatusCode.OK;

    public string Message { get; set; } = string.Empty;
}

public class GenericResult<T> : GenericResult
{
    public GenericResult(int statusCode, string? message = null)
    {
        StatusCode = statusCode;
        Message = message ?? Message;
    }

    public GenericResult(T data, int? statusCode = null, string? message = null)
    {
        Data = data;
        StatusCode = statusCode ?? StatusCode;
        Message = message ?? Message;
    }

    public T Data { get; set; }
}
