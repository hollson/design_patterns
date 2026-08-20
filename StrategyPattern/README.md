# 策略模式（Strategy Pattern）教程

[TOC]

## 一、📖 概述

策略模式是**行为型设计模式**，定义一族**可互换的算法**，分别封装成独立类，并让算法能够在**运行时自由切换**。

核心思想：将算法的定义与使用分离，客户端针对抽象接口编程，不关心具体实现。通过组合替代继承，鸭子可以动态更换飞行和鸣叫行为。

### 核心特性

- **封装性**：每种算法封装为独立类，互不干扰

- **可替换**：运行时通过 `Set` 方法动态切换算法

- **符合开闭原则**：新增算法只需新增类，无需修改现有代码

- **多用组合少用继承**：行为通过组合注入，而非继承绑定

<br/>

## 二、📐 结构图解

### 2.1 整体结构

```mermaid
flowchart TD
    A["客户端"] -->|"配置"| B["上下文 Duck"]
    B -->|"委托"| C["策略接口 IFlyBehaviour"]
    B -->|"委托"| D["策略接口 IQuackBehaviour"]
    C -->|"实现"| E["FlyWings"]
    C -->|"实现"| F["FlyNope"]
    D -->|"实现"| G["QuackNormal"]
    D -->|"实现"| H["QuackSqueak"]
    D -->|"实现"| I["QuackNope"]

    style A fill:#4A90D9,color:#fff
    style B fill:#E67E22,color:#fff
    style C fill:#7B68EE,color:#fff
    style D fill:#7B68EE,color:#fff
    style E fill:#27AE60,color:#fff
    style F fill:#27AE60,color:#fff
    style G fill:#27AE60,color:#fff
    style H fill:#27AE60,color:#fff
    style I fill:#27AE60,color:#fff
```

### 2.2 类关系

```mermaid
classDiagram
    class Duck {
        -IFlyBehaviour flyBehaviour
        -IQuackBehaviour quackBehaviour
        +SetFlyBehaviour(IFlyBehaviour)
        +SetQuackBehaviour(IQuackBehaviour)
        +PerformFly()
        +PerformQuack()
    }
    class IFlyBehaviour {
        <<interface>>
        +Fly()
    }
    class IQuackBehaviour {
        <<interface>>
        +Quack()
    }
    class FlyWings {
        +Fly()
    }
    class FlyNope {
        +Fly()
    }
    class QuackNormal {
        +Quack()
    }
    class QuackSqueak {
        +Quack()
    }
    class QuackNope {
        +Quack()
    }

    Duck o-- IFlyBehaviour
    Duck o-- IQuackBehaviour
    IFlyBehaviour <|.. FlyWings
    IFlyBehaviour <|.. FlyNope
    IQuackBehaviour <|.. QuackNormal
    IQuackBehaviour <|.. QuackSqueak
    IQuackBehaviour <|.. QuackNope
```

### 2.3 关键角色

| 角色                              | 说明                               |
| --------------------------------- | ---------------------------------- |
| **策略接口（Strategy）**          | 定义算法的抽象契约                 |
| **具体策略（Concrete Strategy）** | 实现特定算法                       |
| **上下文（Context）**             | 持有策略引用，将行为委托给策略对象 |

<br/>

## 三、💻 代码实现

以鸭子行为为例：不同鸭子有不同的飞行和鸣叫行为，通过策略模式实现行为的动态切换。

### 3.1 策略接口

```csharp
// 飞行策略接口
public interface IFlyBehaviour
{
    void Fly();
}

// 鸣叫策略接口
public interface IQuackBehaviour
{
    void Quack();
}
```

### 3.2 具体策略

```csharp
// 用翅膀飞
public class FlyWings : IFlyBehaviour
{
    public void Fly() => Console.WriteLine("Flying With Wings!");
}

// 不会飞
public class FlyNope : IFlyBehaviour
{
    public void Fly() => Console.WriteLine("Can't Fly!");
}

// 正常嘎嘎叫
public class QuackNormal : IQuackBehaviour
{
    public void Quack() => Console.WriteLine("Quack!");
}

// 吱吱叫
public class QuackSqueak : IQuackBehaviour
{
    public void Quack() => Console.WriteLine("Squeak!");
}

// 不会叫
public class QuackNope : IQuackBehaviour
{
    public void Quack() => Console.WriteLine("<< Silence >>");
}
```

### 3.3 上下文与客户端

```csharp
// 鸭子基类：组合策略对象
public class Duck
{
    protected IFlyBehaviour _flyBehaviour;
    protected IQuackBehaviour _quackBehaviour;

    public void SetFlyBehaviour(IFlyBehaviour fb) => _flyBehaviour = fb;
    public void SetQuackBehaviour(IQuackBehaviour qb) => _quackBehaviour = qb;

    public void PerformFly() => _flyBehaviour.Fly();
    public void PerformQuack() => _quackBehaviour.Quack();
}

// 具体鸭子：构造时装配默认策略
public class MallardDuck : Duck
{
    public MallardDuck()
    {
        _flyBehaviour = new FlyWings();
        _quackBehaviour = new QuackNormal();
    }
}
```

### 3.4 运行时切换

```csharp
var duck = new MallardDuck();
duck.PerformQuack();   // Quack!
duck.PerformFly();     // Flying With Wings!

// 运行时切换为"不会飞"
duck.SetFlyBehaviour(new FlyNope());
duck.PerformFly();     // Can't Fly!
```

**运行结果**：

```
Quack!
Flying With Wings!
Can't Fly!
```

<br/>

## 四、🔍 核心解析

### 4.1 策略接口

`IFlyBehaviour` 和 `IQuackBehaviour` 定义了行为的抽象契约。鸭子只依赖接口，不关心具体实现，新增行为只需新增实现类。

### 4.2 上下文委托

`Duck` 持有两个策略引用，将 `PerformFly` / `PerformQuack` 委托给对应策略对象执行，自身不包含行为逻辑。

### 4.3 运行时切换

通过 `SetFlyBehaviour` / `SetQuackBehaviour` 方法，客户端可在运行时替换策略对象，无需创建新鸭子实例。

<br/>

## 五、🎯 应用场景

### 5.1 适用场景

- 多种算法需要在运行时动态切换

- 不同对象共享相同行为接口但实现各异

- 需要用组合替代继承来消除类爆炸

### 5.2 实际案例

- **排序策略**：根据数据规模选择冒泡、快排、归并

- **支付方式**：支付宝、微信、银行卡动态切换

- **路线规划**：最快、最短、最便宜路线切换

<br/>

## 六、⚖️ 优缺点分析

### 6.1 优点

- **算法可替换**：运行时动态切换，无需修改上下文代码

- **符合开闭原则**：新增算法不修改已有类

- **消除条件分支**：用多态替代 `if-else` / `switch` 选择算法

### 6.2 缺点

- **类数量增多**：每种算法需要一个独立类

- **客户端需感知策略**：调用方需要知道有哪些策略可选

<br/>

## 七、📝 总结

- **核心思想**：定义一族算法，封装成独立类，运行时自由切换

- **关键角色**：策略接口、具体策略、上下文

- **适用场景**：多种算法动态切换，需要消除继承带来的类爆炸

- **注意事项**：策略类数量随算法增长，设计时需合理划分粒度

---

## 八、🔬 策略模式与状态模式对比

两者结构相似（都通过组合+接口实现多态），但**意图完全不同**：

| 对比项       | 策略模式                   | 状态模式                               |
| ------------ | -------------------------- | -------------------------------------- |
| **意图**     | 让客户端**主动选择**算法   | 对象**被动**随内部状态变化行为         |
| **切换时机** | 由外部（客户端）决定切换   | 由内部（状态对象）自动切换             |
| **状态感知** | 策略之间互不知道对方存在   | 状态对象持有上下文引用，可触发状态转换 |
| **切换方向** | 平级替换，无先后关系       | 有明确的状态流转图（A → B → C）        |
| **典型场景** | 支付方式选择、排序算法切换 | 订单流转、游戏AI状态、TCP连接状态      |

**核心区别**：策略模式中，`Duck` 的飞行行为由**客户端主动调用** `SetFlyBehaviour()` 切换；状态模式中，`GumballMachine` 的状态由**状态对象自身在动作执行后自动切换**（如 `NoQuarterState.InsertQuarter()` 自动切到 `HasQuarterState`）。

**如何选择**：行为选项固定且由外部控制 → 策略模式；行为随内部事件自动流转且有状态转换规则 → 状态模式。
