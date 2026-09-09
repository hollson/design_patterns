namespace AdapterPattern;

/// <summary>国标插座（目标接口）：客户端期望的供电接口</summary>
public interface IStdSocket
{
    void PowerOn();          // 两脚扁平插孔供电
}
