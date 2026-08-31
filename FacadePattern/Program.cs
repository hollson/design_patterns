// 外观模式（Facade Pattern）：为子系统中的一组接口提供一个一致的高层接口，
// 将复杂系统的多个接口统一成一个简单接口，降低客户端使用复杂度。

using FacadePattern;

Console.WriteLine("\n========== 外观模式 (Facade Pattern) ==========");
Console.WriteLine("为子系统中的一组接口提供一个统一的接口\n");

var dimmer = new Dimmer();
var dvdPlayer = new DvdPlayer();
var dvd = new Dvd("Gone with the Wind 2 : Electric Bugaloo");
var homeTheater = new HomeTheatreFacade(dimmer, dvd, dvdPlayer);

homeTheater.WatchMovie();
Console.WriteLine();
homeTheater.Pause();
Console.WriteLine();
homeTheater.Resume();
Console.WriteLine();
homeTheater.Pause();
