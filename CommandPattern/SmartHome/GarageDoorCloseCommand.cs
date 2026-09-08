namespace CommandPattern;

/// <summary>
/// 具体命令，封装关闭车库门动作，撤销 = 开门。
/// </summary>
public class GarageDoorCloseCommand : ICommand
{
    private readonly Garage _garage;

    public GarageDoorCloseCommand(Garage garage) => _garage = garage;

    public void Execute() => _garage.Close();

    public void Undo() => _garage.Open();
}
