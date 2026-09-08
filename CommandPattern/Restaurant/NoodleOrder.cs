namespace CommandPattern;

/// <summary>
/// 具体命令，绑定厨师（接收者），将 Cook 映射为煮面动作。
/// </summary>
public class NoodleOrder : IOrder
{
    private readonly Chef _chef;

    public NoodleOrder(Chef chef) => _chef = chef;

    public void Cook() => _chef.CookNoodles();
}
