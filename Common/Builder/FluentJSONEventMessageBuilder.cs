using Common.Model;

namespace Common.Builder;

public class FluentJSONEventMessageBuilder : IFluentEventMessageBuilder
{
    private JsonEventMessage _message;

    public static FluentJSONEventMessageBuilder Create() => new FluentJSONEventMessageBuilder();

    public FluentJSONEventMessageBuilder()
    {
        _message = new JsonEventMessage();
    }

    public IFluentEventMessageBuilder WithAuthor(Guid authorId)
    {
        _message.AuthorId = authorId;
        return this;
    } 

    public IFluentEventMessageBuilder WithChannel(string channel)
    {
        _message.Channel = channel;
        return this;
    }

    public IFluentEventMessageBuilder WithEventType(string eventType)
    {
        _message.EventType = eventType;
        return this;
    }

    public IFluentEventMessageBuilder WithId(Guid id)
    {
        _message.Id = id;
        return this;
    }

    public IFluentEventMessageBuilder WithCorrelationId(Guid correlationId) 
    {
        _message.CorrelationId = correlationId;
        return this;
    }

    public IFluentEventMessageBuilder WithOrigin(Guid origin)
    {
        _message.Origin = origin;
        return this;
    }

    public IFluentEventMessageBuilder WithTimestamp(DateTime timestamp)
    {
        _message.Timestamp = timestamp;
        return this;
    }

    public IFluentEventMessageBuilder WithTransactionEvent(TransactionEvent transactionEvent)
    {
        _message.TransactionEvent = transactionEvent;
        return this;
    }

    public IFluentEventMessageBuilder WithUserEvent(UserEvent userEvent)
    {
        _message.UserEvent = userEvent;
        return this;
    }

    public void Reset() => _message = new JsonEventMessage();

    public IEventMessage Build()
    {
        var message = _message;
        Reset();
        return message;
    }
}
