using Common.Model;

namespace Common.Builder;

public class JSONEventMessageBuilder : IEventMessageBuilder
{
    private JsonEventMessage _message;

    public JSONEventMessageBuilder() => Reset();

    public void WithAuthor(Guid authorId) => _message.AuthorId = authorId;

    public void WithChannel(string channel) => _message.Channel = channel;

    public void WithEventType(string eventType) => _message.EventType = eventType;

    public void WithId(Guid id) => _message.Id = id;

    public void WithCorrelationId(Guid correlationId) => _message.CorrelationId = correlationId;

    public void WithOrigin(Guid origin) => _message.Origin = origin;

    public void WithTimestamp(DateTime timestamp) => _message.Timestamp = timestamp;

    public void WithTransactionEvent(TransactionEvent transactionEvent) => _message.TransactionEvent = transactionEvent;

    public void WithUserEvent(UserEvent userEvent) => _message.UserEvent = userEvent;

    public void Reset() => _message = new JsonEventMessage();

    public JsonEventMessage Build()
    {
        var message = _message;
        Reset();
        return message;
    }
}
