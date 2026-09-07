using System.Text;

namespace BuilderPattern;

/// <summary>
/// Markdown文档建造者，输出Markdown格式文档。
/// </summary>
public class MarkdownDocumentBuilder : IDocumentBuilder
{
    private readonly StringBuilder _sb = new StringBuilder();

    public void BuildTitle(string title)
    {
        _sb.Append($"# {title}\n");
    }

    public void BuildParagraph(string content)
    {
        _sb.Append($"{content}\n");
    }

    public void BuildImage(string imageUrl)
    {
        _sb.Append($"![image]({imageUrl})\n");
    }

    public string GetResult() => _sb.ToString();
}