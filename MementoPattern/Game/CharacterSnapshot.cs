namespace MementoPattern;

/// <summary>角色快照（备忘录）：只读保存某一刻的角色状态，发起人之外无法修改</summary>
public record CharacterSnapshot(int Level, int Health, int PosX, int PosY)
{
    public string Describe() => $"Lv.{Level} 血量 {Health} 坐标 ({PosX}, {PosY})";
}
