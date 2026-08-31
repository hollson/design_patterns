// 访问者模式示例
// 核心思想：双重分派（Double Dispatch）
//   1. 调用方调用 element.Accept(visitor) —— 第一次分派，由元素类型决定调用哪个 Accept
//   2. Accept 内部调用 visitor.VisitXxx(this) —— 第二次分派，由访问者类型决定具体操作
//   这样在不修改元素类层次的前提下，通过新增访问者即可扩展操作。
//
// 本示例中，Unit 是组合模式的抽象基类，Apartment/Studio/Bedroom/LivingRoom 为具体元素，
// IUnitVisitor 定义了对每种元素的访问方法，各个 XxxVisitor 只关注自己感兴趣的元素类型。

using VisitorPattern;

var apartment = new Apartment(new LivingRoom(), new Bedroom(), new Bedroom());
var studio = new Studio(new LivingRoom(), new Bedroom());
Console.WriteLine("Visiting an Apartment");
apartment.Accept(new ApartmentVisitor());
apartment.Accept(new LivingRoomVisitor());
apartment.Accept(new BedroomVisitor());

Console.WriteLine("Visiting a Studio");
studio.Accept(new StudioVisitor());
studio.Accept(new LivingRoomVisitor());
studio.Accept(new BedroomVisitor());
