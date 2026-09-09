namespace MementoPattern;

/// <summary>存档管理器（管理者）：保管快照但不读不改——只负责存和取</summary>
public class SaveManager
{
    private readonly Dictionary<string, CharacterSnapshot> _slots = [];    // 多存档槽

    public IReadOnlyCollection<string> SlotNames => _slots.Keys;           // 槽位名列表

    /// <summary>写入存档槽</summary>
    public void Save(string slot, CharacterSnapshot snapshot)
    {
        _slots[slot] = snapshot;                                          // 覆盖同名槽
        Console.WriteLine($"[管理] 快照已存入槽位「{slot}」");
    }

    /// <summary>读取存档槽</summary>
    public CharacterSnapshot Load(string slot) =>
        _slots.TryGetValue(slot, out var snapshot)
            ? snapshot
            : throw new KeyNotFoundException($"存档槽「{slot}」不存在");
}
