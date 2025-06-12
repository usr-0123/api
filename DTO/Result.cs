using System.Net;
using api.DTO.Roles;

namespace api.DTO;

public class Result
{
    public bool Succeeded => Error == null;
    public string Error { get; set; }
    public string Message { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public string Meta  { get; protected set; }
    public static Result Success(HttpStatusCode statusCode, string message) => new() { StatusCode = statusCode, Message = message };
    public static Result Failed(HttpStatusCode statusCode, string error, string meta = null) => new() { StatusCode = statusCode, Message = error, Meta = meta };
}

public class Result<TValue>
{
    public bool Succeeded => Error == null;
    public string Message { get; protected set; }
    public string Error { get; protected set; }
    public HttpStatusCode StatusCode { get; protected set; }
    public TValue Value { get; protected set; }
    public string Meta { get; protected set; }
    public static Result<TValue> Success(HttpStatusCode statusCode, TValue value, string message = null) => new() { StatusCode = statusCode, Value = value, Meta = message };
    public static Result<TValue> Failed(HttpStatusCode statusCode, string error, string meta = null) => new() { StatusCode = statusCode, Error = error, Meta = meta };

    internal static Result<RoleDto> Sucess(HttpStatusCode ok, IAsyncEnumerable<GetUserRolesResponseDto> response,
        List<RoleDto> results)
    {
        throw new NotImplementedException();
    }
}