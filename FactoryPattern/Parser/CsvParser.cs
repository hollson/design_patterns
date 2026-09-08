namespace FactoryPattern;

/// <summary>CSV 解析器（具体产品）：真实计算行列数</summary>
public class CsvParser : IDataParser
{
    public string Format => ".csv";

    public string Parse(string fileName, string content)
    {
        string[] lines = [.. content.Split('\n', StringSplitOptions.RemoveEmptyEntries)];
        int cols = lines[0].Split(',').Length;
        return $"[解析] {fileName}（CSV）：按分隔符切分为 {lines.Length} 行 × {cols} 列";
    }
}
