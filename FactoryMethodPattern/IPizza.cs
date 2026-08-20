// 抽象产品
public interface IPizza
{
    string Name { get; }
    void Prepare();
    void Bake();
    void Cut();
    void Box();
}
