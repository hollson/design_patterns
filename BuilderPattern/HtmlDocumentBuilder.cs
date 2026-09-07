using System.Text;

namespace BuilderPattern;

/// <summary>
/// HTML文档建造者，输出HTML格式文档。
/// </summary>
public class HtmlDocumentBuilder : IDocumentBuilder
{
    private readonly StringBuilder _sb = new StringBuilder();

    public void BuildTitle(string title)
    {
        _sb.Append($"<h1>{title}</h1>\n");
    }

    public void BuildParagraph(string content)
    {
        _sb.Append($"<p>{content}</p>\n");
    }

    public void BuildImage(string imageUrl)
    {
        _sb.Append($"<img src=\"{imageUrl}\" />\n");
    }

    public string GetResult() => _sb.ToString();
}