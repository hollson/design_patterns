// 外观模式（Facade Pattern）：为子系统中的一组接口提供统一的高层接口，
// 降低客户端与子系统的耦合度——客户端只调一个方法，内部帮你协调多个子系统。

using FacadePattern;

Console.WriteLine("\n========== 外观模式 (Facade Pattern) ==========");
Console.WriteLine("为子系统中的一组接口提供一个统一的接口\n");

// ========== ① 编译器 (GoF 经典) ==========
Console.WriteLine("--- 编译器 (Compiler Demo) ---");

var compiler = new Compiler();
compiler.Compile("hello.cs");
Console.WriteLine("");

// ========== ② 家庭影院 (Head First 经典) ==========
Console.WriteLine("--- 家庭影院 (Home Theater Demo) ---");

var theater = new HomeTheaterFacade();
theater.WatchMovie("流浪地球");
Console.WriteLine("");
theater.EndMovie();