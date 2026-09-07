namespace BuilderPattern;

/// <summary>
/// 文档指挥者，固定组装流程。
/// </summary>
public class DocumentDirector
{
    /// <summary>
    /// 固定流程：生成一篇标准文章。
    /// </summary>
    public void Construct(IDocumentBuilder builder)
    {
        builder.BuildTitle("设计模式笔记");
        builder.BuildParagraph("GoF建造者模式，构建流程与表示互相分离。");
        builder.BuildImage("/demo/photo.png");
    }
}