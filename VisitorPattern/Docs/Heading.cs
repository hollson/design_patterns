namespace VisitorPattern;

/// <summary>标题（具体元素）</summary>
public class Heading(string text) : DocElement
{
    public string Text { get; } = text;

    public override void Accept(IExporter exporter) => exporter.VisitHeading(this);
}
