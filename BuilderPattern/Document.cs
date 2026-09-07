namespace BuilderPattern;

/// <summary>
/// 文档类，包含标题、段落和图片URL等属性。
/// </summary>
public class Document
{
    public string Title { get; set; } = string.Empty;
    public string Paragraph { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}