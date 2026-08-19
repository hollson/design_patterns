namespace CommandPattern;

/// <summary>
/// 打开车库门命令，封装车库的打开动作
/// </summary>
internal class GarageDoorOpenCommand : ICommand
{
    private readonly Garage _garage;

    public GarageDoorOpenCommand(Garage g)
    {
        _garage = g;
    }

    public void Execute()
    {
        _garage.Open();
    }

    public void Undo()
    {
        _garage.Close();
    }
}
