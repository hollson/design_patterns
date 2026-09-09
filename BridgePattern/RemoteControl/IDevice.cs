namespace BridgePattern;

/// <summary>设备（实现维度）：遥控器控制的家电，可独立新增品牌</summary>
public interface IDevice
{
    string Name { get; }              // 设备名

    bool IsOn { get; }                // 开机状态

    int Volume { get; set; }          // 音量 0-100

    void TurnOn();                    // 开机

    void TurnOff();                   // 关机
}
