// Legacy 版本：用枚举 + switch 分支管理状态
// 与现代版对比——现代版将每个状态封装为独立类，符合开闭原则，新增状态无需修改已有分支

namespace StatePattern.Legacy;

/// <summary>
/// 旧式糖果机状态枚举
/// </summary>
public enum State
{
    Sold, HasQuarters, NoQuarters, NoGumballs
}
