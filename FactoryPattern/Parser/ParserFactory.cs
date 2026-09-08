using System.Collections.Frozen;

namespace FactoryPattern;

/// <summary>解析器工厂（简单工厂·字典版）：注册表式创建，O(1) 查找</summary>
public static class ParserFactory
{
    // FrozenDictionary（.NET 8+）：构建后不再变化，查找比普通字典更快
    private static readonly FrozenDictionary<string, IDataParser> _parsers =
        new Dictionary<string, IDataParser>
        {
            [".json"] = new JsonParser(),
            [".xml"] = new XmlParser(),
            [".csv"] = new CsvParser(),
        }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase);

    /// <summary>按扩展名取解析器——新增格式只需在这里注册一行</summary>
    public static IDataParser GetParser(string extension) =>
        _parsers.TryGetValue(extension, out var parser)
            ? parser
            : throw new NotSupportedException($"不支持的文件格式：{extension}");
}
