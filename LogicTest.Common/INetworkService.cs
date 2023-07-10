namespace LogicTest.Common;

public interface INetworkService
{
    void Init(int networkLength);
    void Connect(int source, int target);
    bool Query(int source, int target);
}
