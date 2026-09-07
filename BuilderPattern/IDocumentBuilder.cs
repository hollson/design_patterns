namespace BuilderPattern;

/// <summary>
/// 文档建造者接口，定义了构建文档的各个步骤。
/// </summary>
public interface IDocumentBuilder
{
    void BuildTitle(string title);
    void BuildParagraph(string content);
    void BuildImage(string imageUrl);
    string GetResult();
}