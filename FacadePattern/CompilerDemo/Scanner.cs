namespace FacadePattern;

/// <summary>
/// 词法分析器子系统：将源代码字符流分解为 Token 序列。
/// </summary>
public class Scanner
{
    public void Scan(string source)
    {
        Console.WriteLine("[Scanner] 词法分析: " + source);
    }
}