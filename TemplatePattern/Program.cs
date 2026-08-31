// 模板方法模式示例
// 展示了 Beverage 抽象基类定义的算法骨架（煮水→冲泡→倒杯→加料），
// 子类只需覆写 Brew() 和 AddCondiments() 即可产生不同的饮品行为。
// 同时演示了 IComparable 接口在集合排序中的应用。

using TemplatePattern;
using TemplatePattern.Comparable;

var tea = new Tea();
var coffee = new Coffee();
tea.WantsCondiments = true;
tea.AddSugar = 5;
tea.Prepare();

Console.WriteLine();
coffee.WantsCondiments = true;
coffee.Prepare();

var people = new List<Person> { new("Ram", 25), new("Abishek", 12), new("Ram", 18), new("Abishek", 18) };
foreach (var person in people)
{
    Console.Write(person);
}
people.Sort();
Console.WriteLine();
foreach (var person in people)
{
    Console.Write(person);
}
