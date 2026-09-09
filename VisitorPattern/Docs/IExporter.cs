namespace VisitorPattern;

/// <summary>文档导出器（抽象访问者）：对每种文档元素定义一个 Visit 方法</summary>
public interface IExporter
{
    void VisitHeading(Heading heading);           // 导出标题

    void VisitParagraph(Paragraph paragraph);     // 导出段落

    void VisitCodeBlock(CodeBlock codeBlock);     // 导出代码块
}
