namespace FactoryPattern;

/// <summary>JSON 解析器（具体产品）</summary>
public class JsonParser : IDataParser
{
    public string Format => ".json";

    public string Parse(string fileName, string content) =>
        $"[解析] {fileName}（JSON）：读取 {content.Length} 字符，反序列化为对象树";
}
