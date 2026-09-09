namespace MediatorPattern;

/// <summary>群聊聊天室（具体中介者）：维护在线名单，消息统一转发</summary>
public class ChatRoom
{
    private readonly List<ChatUser> _users = [];            // 在线名单

    /// <summary>用户上线</summary>
    public void Register(ChatUser user)
    {
        _users.Add(user);
        Console.WriteLine($"[系统] {user.Name} 加入了聊天室（当前 {_users.Count} 人在线）");
    }

    /// <summary>用户下线：从名单移除</summary>
    public void Unregister(ChatUser user)
    {
        _users.Remove(user);
        Console.WriteLine($"[系统] {user.Name} 离开了聊天室");
    }

    /// <summary>广播：发给除发送者外的所有人</summary>
    public void Broadcast(ChatUser sender, string message)
    {
        foreach (var user in _users)
        {
            if (!ReferenceEquals(user, sender))
                user.Receive(sender.Name, message);
        }
    }
}
