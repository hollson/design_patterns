namespace VisitorPattern;

/// <summary>代码块（具体元素）</summary>
public class CodeBlock(string code) : DocElement
{
    public string Code { get; } = code;

    public override void Accept(IExporter exporter) => exporter.VisitCodeBlock(this);
}
