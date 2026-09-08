namespace FactoryPattern;

/// <summary>XML 解析器（具体产品）</summary>
public class XmlParser : IDataParser
{
    public string Format => ".xml";

    public string Parse(string fileName, string content) =>
        $"[解析] {fileName}（XML）：读取 {content.Length} 字符，构建 DOM 文档";
}
