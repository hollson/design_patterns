namespace CommandPattern;

/// <summary>
/// 命令接口，定义执行与撤销的统一契约，调用者只依赖它。
/// </summary>
public interface ICommand
{
    void Execute();

    void Undo();
}
