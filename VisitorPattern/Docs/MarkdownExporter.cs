namespace VisitorPattern;

/// <summary>Markdown 导出器（具体访问者）</summary>
public class MarkdownExporter : IExporter
{
    public void VisitHeading(Heading heading) =>
        Console.WriteLine($"# {heading.Text}");

    public void VisitParagraph(Paragraph paragraph) =>
        Console.WriteLine(paragraph.Text);

    public void VisitCodeBlock(CodeBlock codeBlock) =>
        Console.WriteLine($"```csharp\n{codeBlock.Code}\n```");
}
