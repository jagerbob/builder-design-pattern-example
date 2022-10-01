using Common.Model;

namespace Common.Builder;

public class FluentJSONEventMessageBuilder : IFluentEventMessageBuilder<JsonEventMessage>
{
    private JsonEventMessage _message;

    public static FluentJSONEventMessageBuilder Create() => new FluentJSONEventMessageBuilder();

    public FluentJSONEventMessageBuilder()
    {
        _message = new JsonEventMessage();
    }

    public IFluentEventMessageBuilder<JsonEventMessage> WithAuthor(Guid authorId)
    {
        _message.AuthorId = authorId;
        return this;
    } 

    public IFluentEventMessageBuilder<JsonEventMessage> WithChannel(string channel)
    {
        _message.Channel = channel;
        return this;
    }

    public IFluentEventMessageBuilder<JsonEventMessage> WithEventType(string eventType)
    {
        _message.EventType = eventType;
        return this;
    }

    public IFluentEventMessageBuilder<JsonEventMessage> WithId(Guid id)
    {
        _message.Id = id;
        return this;
    }

    public IFluentEventMessageBuilder<JsonEventMessage> WithCorrelationId(Guid correlationId) 
    {
        _message.CorrelationId = correlationId;
        return this;
    }

    public IFluentEventMessageBuilder<JsonEventMessage> WithOrigin(Guid origin)
    {
        _message.Origin = origin;
        return this;
    }

    public IFluentEventMessageBuilder<JsonEventMessage> WithTimestamp(DateTime timestamp)
    {
        _message.Timestamp = timestamp;
        return this;
    }

    public IFluentEventMessageBuilder<JsonEventMessage> WithTransactionEvent(TransactionEvent transactionEvent)
    {
        _message.TransactionEvent = transactionEvent;
        return this;
    }

    public IFluentEventMessageBuilder<JsonEventMessage> WithUserEvent(UserEvent userEvent)
    {
        _message.UserEvent = userEvent;
        return this;
    }

    public void Reset() => _message = new JsonEventMessage();

    public JsonEventMessage Build()
    {
        var message = _message;
        Reset();
        return message;
    }

    public static implicit operator JsonEventMessage(FluentJSONEventMessageBuilder builder) => builder.Build();

}
