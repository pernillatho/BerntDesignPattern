using ChatRoomMediatorPattern.Component;

namespace ChatRoomMediatorPattern.Interfaces;

public interface IMediator
{
    void Notify(string sender, string receiver, string message);

    void Register(BaseComponent user);
}