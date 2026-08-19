namespace CommandPattern;

/// <summary>
/// 关灯命令，封装灯光的关闭动作
/// </summary>
internal class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light l)
    {
        _light = l;
    }

    public void Execute()
    {
        _light.Off();
    }

    public void Undo()
    {
        _light.On();
    }
}
