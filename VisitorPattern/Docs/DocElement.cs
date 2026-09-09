namespace VisitorPattern;

/// <summary>文档元素（抽象元素）：文档结构稳定，导出格式多变</summary>
public abstract class DocElement
{
    /// <summary>接受导出器：双分派第一步</summary>
    public abstract void Accept(IExporter exporter);
}
