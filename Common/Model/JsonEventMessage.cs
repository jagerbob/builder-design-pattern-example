namespace Common.Model;

public class JsonEventMessage
{
    public Guid Id { get; set; }
    public Guid? CorrelationId { get; set; }
    public Guid Origin { get; set; }
    public DateTime Timestamp { get; set; }
    public Guid? AuthorId { get; set; }
    public string Channel { get; set; }
    public string EventType { get; set; }
    public string Description { get; set; }
    public UserEvent UserEvent { get; set; }
    public TransactionEvent TransactionEvent { get; set; }

    public JsonEventMessage() { }

    public JsonEventMessage(
        Guid id,
        Guid? correlationId,
        Guid origin,
        DateTime timestamp,
        Guid? authorId,
        string channel,
        string eventType,
        UserEvent userEvent,
        TransactionEvent transactionEvent)
    {
        Id = id;
        CorrelationId = correlationId;
        Origin = origin;
        Timestamp = timestamp;
        AuthorId = authorId;
        Channel = channel;
        EventType = eventType;
        UserEvent = userEvent;
        TransactionEvent = transactionEvent;
    }
}
