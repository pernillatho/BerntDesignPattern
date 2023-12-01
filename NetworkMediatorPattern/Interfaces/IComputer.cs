namespace NetworkMediatorPattern.Interfaces;

public interface IComputer
{
    string Name { get; init; }
    void SendingMessage(string receiver, string message);
    void ReceivedMessage(string sender, string message);
    void BroadCastMessage(string message);
}