namespace MediatorPattern;

/// <summary>客机（具体同事）：按塔台指令执行</summary>
public class Airliner(string callSign) : Aircraft(callSign)
{
    public override void Receive(string instruction) =>
        Console.WriteLine($"[客机] {CallSign} 收到塔台指令：{instruction}");
}
