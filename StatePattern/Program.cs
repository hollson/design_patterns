// 状态模式（State Pattern）：允许对象在内部状态改变时改变自身行为，
// 状态对象替代大量 if-else/switch 分支，状态转换由各状态类自行决定。
// 本示例演示两种应用：经典糖果机（生活场景）、电商订单流转（软件项目）。

using StatePattern;

Console.WriteLine("\n========== 状态模式 (State Pattern) ==========");
Console.WriteLine("允许对象在内部状态改变时改变其行为\n");

// ① 经典场景：自动糖果机
Console.WriteLine("--- 经典场景: 自动糖果机 ---");
var machine = new GumballMachine(2);

Console.WriteLine(">> 转动摇杆（未投币）");
machine.TurnCrank();
Console.WriteLine(">> 投币");
machine.InsertQuarter();
Console.WriteLine(">> 再次投币");
machine.InsertQuarter();
Console.WriteLine(">> 转动摇杆");
machine.TurnCrank();
Console.WriteLine(">> 投币 + 转动摇杆");
machine.InsertQuarter();
machine.TurnCrank();
Console.WriteLine(">> 投币（已售罄）");
machine.InsertQuarter();
Console.WriteLine("\n");

// ② 软件项目：电商订单流转
Console.WriteLine("--- 软件项目: 电商订单流转 ---");

// 正常流程：待支付 → 已支付 → 已发货 → 已完成
var order1 = new Order("SO-1001");
Console.WriteLine(">> 支付");
order1.Pay();
Console.WriteLine(">> 发货");
order1.Ship();
Console.WriteLine(">> 确认收货");
order1.Complete();
Console.WriteLine(">> 完成后取消");
order1.Cancel();
Console.WriteLine();

// 异常流程：非法操作被当前状态拒绝，中途取消进入终结态
var order2 = new Order("SO-1002");
Console.WriteLine(">> 未支付直接发货");
order2.Ship();
Console.WriteLine(">> 支付");
order2.Pay();
Console.WriteLine(">> 支付后取消");
order2.Cancel();
Console.WriteLine(">> 取消后再支付");
order2.Pay();
