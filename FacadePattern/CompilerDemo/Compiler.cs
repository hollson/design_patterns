namespace FacadePattern;

/// <summary>
/// 编译器外观：封装词法分析 → 语法分析 → 代码生成的完整流程，客户端只需调用 Compile()。
/// </summary>
public class Compiler
{
    public void Compile(string source)
    {
        var scanner = new Scanner();
        var parser = new Parser();
        var codeGen = new CodeGenerator();

        scanner.Scan(source);
        parser.Parse();
        codeGen.Generate();
        Console.WriteLine("编译完成");
    }
}