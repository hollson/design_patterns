namespace ChainOfResponsibilityPattern;

/// <summary>HTTP 请求上下文（请求对象）：携带请求信息与响应结果</summary>
public class HttpContext(string method, string path)
{
    public string Method { get; } = method;         // 请求方法

    public string Path { get; } = path;             // 请求路径

    public string? Token { get; init; }             // 认证令牌（可空）

    public int StatusCode { get; set; }             // 响应状态码

    public string Response { get; set; } = string.Empty;
}
