namespace VisitorPattern;

/// <summary>HTML 导出器（具体访问者）——新增导出格式 = 新增一个类，文档元素零改动</summary>
public class HtmlExporter : IExporter
{
    public void VisitHeading(Heading heading) =>
        Console.WriteLine($"<h1>{heading.Text}</h1>");

    public void VisitParagraph(Paragraph paragraph) =>
        Console.WriteLine($"<p>{paragraph.Text}</p>");

    public void VisitCodeBlock(CodeBlock codeBlock) =>
        Console.WriteLine($"<pre><code>{codeBlock.Code}</code></pre>");
}
