namespace MementoPattern;

/// <summary>游戏角色（发起人）：真实状态由自己保管，快照只经自己之手创建/恢复</summary>
public class GameCharacter(int level, int health, int posX, int posY)
{
    private int _level = level;
    private int _health = health;
    private int _posX = posX;
    private int _posY = posY;

    public void Show() =>
        Console.WriteLine($"[状态] Lv.{_level} 血量 {_health} 坐标 ({_posX}, {_posY})");

    /// <summary>被怪物攻击：掉血</summary>
    public void TakeDamage(int damage)
    {
        _health = Math.Max(0, _health - damage);
        Console.WriteLine($"[战斗] 受到 {damage} 点伤害，剩余血量 {_health}");
    }

    /// <summary>击败 Boss：升级</summary>
    public void LevelUp()
    {
        _level++;
        Console.WriteLine($"[升级] 恭喜升到 Lv.{_level}");
    }

    /// <summary>往前走 10 步</summary>
    public void MoveForward()
    {
        _posX += 10;
        Console.WriteLine($"[移动] 前进到 ({_posX}, {_posY})");
    }

    /// <summary>创建存档：把内部状态打包成快照（窄接口——外界拿到也改不了内容）</summary>
    public CharacterSnapshot CreateSnapshot()
    {
        Console.WriteLine($"[存档] 已保存当前进度");
        return new(_level, _health, _posX, _posY);
    }

    /// <summary>读取存档：只有发起人自己知道怎么把快照写回内部</summary>
    public void Restore(CharacterSnapshot snapshot) => (_level, _health, _posX, _posY) =
        (snapshot.Level, snapshot.Health, snapshot.PosX, snapshot.PosY);
}
