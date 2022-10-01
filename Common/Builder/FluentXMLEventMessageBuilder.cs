using Common.Model;

namespace Common.Builder;

public class FluentXMLEventMessageBuilder : IFluentEventMessageBuilder
{
    private XMLEventMessage _message;

    public static FluentXMLEventMessageBuilder Create() => new FluentXMLEventMessageBuilder();

    public FluentXMLEventMessageBuilder()
    {
        _message = new XMLEventMessage();
    }

    public IFluentEventMessageBuilder WithAuthor(Guid authorId)
    {
        _message.Header.AuthorId = authorId;
        return this;
    } 

    public IFluentEventMessageBuilder WithChannel(string channel)
    {
        _message.Body.Channel = channel;
        return this;
    }

    public IFluentEventMessageBuilder WithEventType(string eventType)
    {
        _message.Body.EventType = eventType;
        return this;
    }

    public IFluentEventMessageBuilder WithId(Guid id)
    {
        _message.Header.Id = id;
        return this;
    }

    public IFluentEventMessageBuilder WithCorrelationId(Guid correlationId) 
    {
        _message.Header.CorrelationId = correlationId;
        return this;
    }

    public IFluentEventMessageBuilder WithOrigin(Guid origin)
    {
        _message.Header.Origin = origin;
        return this;
    }

    public IFluentEventMessageBuilder WithTimestamp(DateTime timestamp)
    {
        _message.Header.Timestamp = timestamp;
        return this;
    }

    public IFluentEventMessageBuilder WithTransactionEvent(TransactionEvent transactionEvent)
    {
        _message.Body.TransactionEvent = transactionEvent;
        return this;
    }

    public IFluentEventMessageBuilder WithUserEvent(UserEvent userEvent)
    {
        _message.Body.UserEvent = userEvent;
        return this;
    }

    public void Reset() => _message = new XMLEventMessage();

    public IEventMessage Build()
    {
        var message = _message;
        Reset();
        return message;
    }
}
