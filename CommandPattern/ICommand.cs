namespace CommandPattern;

/// <summary>
/// 命令接口，定义执行和撤销操作的契约
/// </summary>
internal interface ICommand
{
    /// <summary>
    /// 执行命令
    /// </summary>
    void Execute();

    /// <summary>
    /// 撤销命令
    /// </summary>
    void Undo();
}
