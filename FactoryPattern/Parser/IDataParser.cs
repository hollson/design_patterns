namespace FactoryPattern;

/// <summary>数据解析器（产品）：按格式解析原始内容</summary>
public interface IDataParser
{
    string Format { get; }                                  // 支持的文件扩展名

    string Parse(string fileName, string content);          // 解析并返回结果摘要
}
