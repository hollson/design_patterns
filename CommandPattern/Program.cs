// 命令模式（Command Pattern）
// 将请求封装为对象，从而使你可以用不同的请求参数化客户端，
// 支持请求的排队、日志记录以及撤销操作。

// 创建遥控器（调用者）
var remote = new RemoteControl(3);

// 创建车库对象（接收者）和对应命令
var bike = new Garage("Bike");
var bikeDoorClose = new GarageDoorCloseCommand(bike);
var bikeDoorOpen = new GarageDoorOpenCommand(bike);

var car = new Garage("Car");
var carDoorClose = new GarageDoorCloseCommand(car);
var carDoorOpen = new GarageDoorOpenCommand(car);

// 将车库开关命令绑定到遥控器槽位 0
var garageButton = new OnOffStruct
{
    On = bikeDoorOpen,
    Off = bikeDoorClose
};

remote[0] = garageButton;
remote.PushOn(0);
remote.PushUndo();
remote.PushUndo();
remote.PushOff(0);

Console.WriteLine();

// 宏命令：一键控制多个设备
var light = new Light("Hall");

ICommand[] partyOn = [new LightOffCommand(light), bikeDoorOpen, carDoorOpen];
ICommand[] partyOff = [new LightOnCommand(light), bikeDoorClose, carDoorClose];

remote[2] = new OnOffStruct { On = new MacroCommand(partyOn), Off = new MacroCommand(partyOff) };

try
{
    remote.PushOn(2);
    Console.WriteLine();
    remote.PushOff(2);
}
catch (Exception)
{
    Console.WriteLine("Oops");
}
