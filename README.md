<div align="center">
<h1>GoF 设计模式 🎯</h1>
<a href="#"><img src="https://img.shields.io/badge/.NET-11.0-purple?logo=dotnet&logoColor=fff" /></a>
<a href="#"><img src="https://img.shields.io/badge/C%23-13.0-blue?logo=csharp&logoColor=fff" /></a>
<a href="#"><img src="#"><img src="https://img.shields.io/badge/GoF-23%20Patterns-orange" /></a>
<a href="#"><img src="https://img.shields.io/badge/Refactoring.Guru-Visual%20Guide-blue" /></a>
<a href="#"><img src="https://img.shields.io/badge/License-MIT-green" /></a>
<p>设计模式 - 可复用面向对象软件的基础</p>
</div>



<br/>

## 概述

本仓库提供现代 C# 风格的设计模式实现，每个模式包含：

- **伪代码教程**：循序渐进的讲解
- **Mermaid 图表**：可视化理解结构
- **真实案例**：拒绝 Animal/Shape 等抽象示例
- **对比分析**：与相似模式的区别
- **最佳实践**：何时使用、何时避免


<br/>

## 模式总览

### 创建型模式

关注对象创建机制，提高灵活性和复用性。

| ID | 模式 | 难易 | 描述 | 核心概念 |
|----|------|------|------|----------|
| 01 | [单例模式 (Singleton)](./SingletonPattern) | 🟢 | 确保类只有一个实例 | 全局访问点，线程安全 |
| 02 | [工厂方法模式 (Factory Method)](./FactoryMethodPattern) | 🔵 | 由子类决定创建哪种对象 | 工厂方法，延迟创建 |
| 03 | [抽象工厂模式 (Abstract Factory)](./AbstractFactoryPattern) | 🟠 | 创建一族相关产品的接口 | 产品族一致性 |
| 04 | [建造者模式 (Builder)](./BuilderPattern) | 🔵 | 分步骤构建复杂对象 | `Director` 控制构建流程 |
| 05 | [原型模式 (Prototype)](./PrototypePattern) | 🔵 | 通过克隆已有对象创建新对象 | `ICloneable`，深拷贝与浅拷贝 |

### 结构型模式

关注类和对象的组合方式，形成更大的结构。

| ID | 模式 | 难易 | 描述 | 核心概念 |
|----|------|------|------|----------|
| 06 | [外观模式 (Facade)](./FacadePattern) | 🟢 | 简化复杂子系统的接口 | 统一 API 封装子系统 |
| 07 | [适配器模式 (Adapter)](./AdapterPattern) | 🔵 | 转换不兼容的接口 | 类适配器 vs 对象适配器 |
| 08 | [装饰器模式 (Decorator)](./DecoratorPattern) | 🔵 | 动态添加职责 | 组合优于继承 |
| 09 | [代理模式 (Proxy)](./ProxyPattern) | 🔵 | 控制对另一个对象的访问 | 虚拟代理/远程代理/保护代理 |
| 10 | [桥接模式 (Bridge)](./BridgePattern) | 🟠 | 将抽象与实现分离 | 两个独立的层次结构 |
| 11 | [组合模式 (Composite)](./CompositePattern) | 🟠 | 统一处理叶子和容器对象 | 树形结构，递归遍历 |
| 12 | [享元模式 (Flyweight)](./FlyweightPattern) | 🔴 | 共享公共状态以减少内存 | 内部状态 vs 外部状态 |

### 行为型模式

关注对象之间的通信和职责分配。

| ID | 模式 | 难易 | 描述 | 核心概念 |
|----|------|------|------|----------|
| 13 | [观察者模式 (Observer)](./ObserverPattern) | 🔵 | 定义一对多的依赖关系 | 推模型 vs 拉模型 |
| 14 | [命令模式 (Command)](./CommandPattern) | 🔵 | 将请求封装为对象 | 撤销、宏命令、队列 |
| 15 | [迭代器模式 (Iterator)](./IteratorPattern) | 🔵 | 统一遍历集合 | `IEnumerable<T> yield` |
| 16 | [中介者模式 (Mediator)](./MediatorPattern) | 🟠 | 集中管理复杂通信 | 星形拓扑取代网状结构 |
| 17 | [备忘录模式 (Memento)](./MementoPattern) | 🟠 | 捕获对象内部状态以便恢复 | 发起人、备忘录、管理者 |
| 18 | [状态模式 (State)](./StatePattern) | 🟠 | 行为随状态变化 | 状态机模式 |
| 19 | [策略模式 (Strategy)](./StrategyPattern) | 🔵 | 可互换的算法 | 运行时切换算法 |
| 20 | [职责链模式 (Chain of Responsibility)](./ChainOfResponsibilityPattern) | 🟠 | 沿链传递请求 | 中间件管道模式 |
| 21 | [模板方法模式 (Template Method)](./TemplatePattern) | 🔵 | 定义算法骨架 | 好莱坞原则 |
| 22 | [访问者模式 (Visitor)](./VisitorPattern) | 🔴 | 为元素类定义新操作 | 双重分派机制 |
| 23 | [解释器模式 (Interpreter)](./InterpreterPattern) | 🔴 | 定义文法并解释句子 | 文法规则映射为类 |


<br/>

## 快速开始
- [.NET 11.0 SDK](https://dotnet.microsoft.com/download) 或更高版本
- 任意 C# IDE（Visual Studio、VS Code + C# 扩展、Rider）

```bash
# 1. 克隆仓库
git clone https://github.com/yourusername/design_patterns.git
cd design_patterns

# 2. 运行示例（以工厂模式为例）
cd FactoryPattern
dotnet run
```

_每个模式文件夹包含 README.md，提供详细讲解、图表和代码分析._



<br/>

## 推荐资源

- [《设计模式：可复用面向对象软件的基础》](https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612) - GoF 原著
- [Refactoring.Guru](https://refactoring.guru/design-patterns) - 优秀的可视化讲解
- [Source Making](https://sourcemaking.com/design_patterns) - 详细的模式目录

---

<p align="center">
  <i>为想掌握 C# 设计模式的开发者而做</i>
</p>
