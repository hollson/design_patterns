namespace MediatorPattern;

/// <summary>聊天室用户（具体同事）：发消息走中介，收消息由中介转达</summary>
public class ChatUser(string name)
{
    private ChatRoom? _room;                                // 中介者引用

    public string Name { get; } = name;

    /// <summary>加入聊天室</summary>
    public void Join(ChatRoom room)
    {
        _room = room;
        room.Register(this);
    }

    /// <summary>离开聊天室：解除中介引用，此后发言不再送达</summary>
    public void Leave()
    {
        _room?.Unregister(this);
        _room = null;
    }

    /// <summary>发言：委托给中介者广播，不直接找其他用户</summary>
    public void Send(string message)
    {
        Console.WriteLine($">> {Name} 说：{message}");
        _room?.Broadcast(this, message);
    }

    /// <summary>接收他人消息</summary>
    public void Receive(string from, string message) =>
        Console.WriteLine($"[收到] {Name} ← {from}：{message}");
}
