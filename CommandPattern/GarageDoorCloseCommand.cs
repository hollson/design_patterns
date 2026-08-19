namespace CommandPattern;

/// <summary>
/// 关闭车库门命令，封装车库的关闭动作
/// </summary>
internal class GarageDoorCloseCommand : ICommand
{
    private readonly Garage _garage;

    public GarageDoorCloseCommand(Garage g)
    {
        _garage = g;
    }

    public void Execute()
    {
        _garage.Close();
    }

    public void Undo()
    {
        _garage.Open();
    }
}
