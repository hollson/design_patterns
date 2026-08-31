// 迭代器模式：提供一种方法顺序访问集合中的各个元素，而不暴露其内部表示。
// 使用自定义迭代器遍历早餐菜单和晚餐菜单，客户端通过统一接口消费菜单项。

using IteratorPattern;

Console.WriteLine("\n========== 迭代器模式 (Iterator Pattern) ==========");
Console.WriteLine("提供一种方法顺序访问聚合对象中的元素，而不暴露其内部表示\n");

var breakfast = new BreakfastMenu();
var dinner = new DinnerMenu();
var waiter = new Client(breakfast, dinner);
waiter.PrintMenu();
