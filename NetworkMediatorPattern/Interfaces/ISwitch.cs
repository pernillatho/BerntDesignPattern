namespace NetworkMediatorPattern.Interfaces;

public interface ISwitch
{
    void Notify(string message, string receiver, string sender);
    void NotifyAll(string message, string sender);
    void Register(IComputer iComputer);
}