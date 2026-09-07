// 建造者模式 (Builder Pattern)
// 将一个复杂对象的构建与表示分离，使得同样的构建过程可以创建不同的表示。
// 这里通过不同的建造者(HtmlDocumentBuilder、MarkdownDocumentBuilder)构建不同的文档格式，
// 由指挥者(DocumentDirector)协调构建流程。

using BuilderPattern;

Console.WriteLine("\n========== 建造者模式 (Builder Pattern) ==========");
Console.WriteLine("将复杂对象的构造与表示分离，同样的构造过程可创建不同表示\n");

var director = new DocumentDirector();

// 同一套流程，输出HTML
IDocumentBuilder htmlBuilder = new HtmlDocumentBuilder();
director.Construct(htmlBuilder);
Console.WriteLine("==== HTML 输出 ====");
Console.WriteLine(htmlBuilder.GetResult());

// 同一套流程，输出Markdown
IDocumentBuilder mdBuilder = new MarkdownDocumentBuilder();
director.Construct(mdBuilder);
Console.WriteLine("==== Markdown 输出 ====");
Console.WriteLine(mdBuilder.GetResult());