namespace PrototypePattern;

/// <summary>
/// 原型接口，继承 ICloneable 以支持原型拷贝
/// </summary>
interface IFigure : ICloneable
{
    void GetInfo();
}