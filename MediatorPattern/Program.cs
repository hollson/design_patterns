// 中介者模式：定义一个中介对象来封装一组对象的交互，降低对象间的直接依赖。
// 客户、程序员、测试员通过中介者（经理）进行消息传递，无需直接引用彼此。

using MediatorPattern;

var mediator = new ManagerMediator();
var customer = new Customer(mediator);
var programmer = new Programmer(mediator);
var tester = new Tester(mediator);
mediator.Customer = customer;
mediator.Programmer = programmer;
mediator.Tester = tester;
customer.Send("We have an order, need to make a program");
programmer.Send("I have done program, need to test it");
tester.Send("I have done testing, here is ready program for you");
