namespace CommandPattern;

/// <summary>
/// 开/关命令对，用于将一对命令绑定到遥控器的同一个槽位
/// </summary>
internal struct OnOffStruct
{
    public ICommand On;
    public ICommand Off;
}
