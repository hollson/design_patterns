// 建造者模式 (Builder Pattern)
// 将一个复杂对象的构建与表示分离，使得同样的构建过程可以创建不同的表示。
// 这里通过不同的建造者(MyHamburgerBuilder、WifesHamburgerBuilder)构建不同的汉堡，
// 由指挥者(Cook)协调构建流程。

var builder = new MyHamburgerBuilder();
var cook = new Cook(builder);
var myHamburger = cook.Build();

cook.ChangeBuilder(new WifesHamburgerBuilder());
var wifesHamburger = cook.Build();

Console.WriteLine($"My Hamburger: {myHamburger}");
Console.WriteLine($"My Wife's Hamburger: {wifesHamburger}");
