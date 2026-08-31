// 中介者模式：定义一个中介对象来封装一组对象的交互，降低对象间的直接依赖。
// 客户、程序员、测试员通过中介者（经理）进行消息传递，无需直接引用彼此。

using MediatorPattern;

Console.WriteLine("\n========== 中介者模式 (Mediator Pattern) ==========");
Console.WriteLine("用一个中介对象来封装一系列对象的交互\n");

var mediator = new ManagerMediator();
var customer = new Customer(mediator);
var programmer = new Programmer(mediator);
var tester = new Tester(mediator);
mediator.Customer = customer;
mediator.Programmer = programmer;
mediator.Tester = tester;
customer.Send("我们有一个订单，需要开发一个程序");
programmer.Send("我已完成程序开发，需要测试");
tester.Send("测试已完成，这是给你的可用程序");
