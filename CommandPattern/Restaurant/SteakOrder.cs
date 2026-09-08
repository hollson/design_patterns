namespace CommandPattern;

/// <summary>
/// 具体命令，绑定厨师（接收者），将 Cook 映射为煎牛排动作。
/// </summary>
public class SteakOrder : IOrder
{
    private readonly Chef _chef;

    public SteakOrder(Chef chef) => _chef = chef;

    public void Cook() => _chef.CookSteak();
}
