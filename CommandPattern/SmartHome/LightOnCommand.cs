namespace CommandPattern;

/// <summary>
/// 具体命令，封装开灯动作，撤销 = 反向操作关灯。
/// </summary>
public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light) => _light = light;

    public void Execute() => _light.On();

    public void Undo() => _light.Off();
}
