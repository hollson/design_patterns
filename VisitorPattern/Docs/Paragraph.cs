namespace VisitorPattern;

/// <summary>段落（具体元素）</summary>
public class Paragraph(string text) : DocElement
{
    public string Text { get; } = text;

    public override void Accept(IExporter exporter) => exporter.VisitParagraph(this);
}
