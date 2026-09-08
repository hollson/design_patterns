namespace CommandPattern;

/// <summary>
/// 具体命令，封装打开车库门动作，撤销 = 关门。
/// </summary>
public class GarageDoorOpenCommand : ICommand
{
    private readonly Garage _garage;

    public GarageDoorOpenCommand(Garage garage) => _garage = garage;

    public void Execute() => _garage.Open();

    public void Undo() => _garage.Close();
}
