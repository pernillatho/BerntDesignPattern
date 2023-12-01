using ChatRoomMediatorPattern.Interfaces;

namespace ChatRoomMediatorPattern.Component;

public abstract class BaseComponent
{
    protected IMediator _mediator;
   
    public string Name { get; init; }

    public BaseComponent(IMediator mediator = null)
    {
        this._mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        this._mediator = mediator;
    }

    public abstract void ReceiveMessage(string message, string sender);

    public abstract void SendMessage(string message, string receiver);
}