// 状态模式（State Pattern）—— 糖果机状态管理
// 当对象行为随内部状态改变时，用状态对象替代大量条件分支

using StatePattern;

Console.WriteLine("\n========== 状态模式 (State Pattern) ==========");
Console.WriteLine("允许对象在内部状态改变时改变其行为\n");

LegacyTest();
Console.WriteLine();
var gumballmachine = new GumballMachine(5);
gumballmachine.InsertQuarter();
gumballmachine.TurnCrank();
gumballmachine.InsertQuarter();
gumballmachine.TurnCrank();

static void LegacyTest()
{
    var machine = new StatePattern.Legacy.GumballMachine(2);
    machine.InsertQuarter();
    machine.TurnCrank();
    machine.InsertQuarter();
    machine.EjectQuarter();
    machine.InsertQuarter();
}
