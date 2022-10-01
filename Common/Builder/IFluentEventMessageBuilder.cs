using Common.Model;

namespace Common.Builder;

public interface IFluentEventMessageBuilder
{
    IFluentEventMessageBuilder WithId(Guid id);
    IFluentEventMessageBuilder WithCorrelationId(Guid correlationId);
    IFluentEventMessageBuilder WithOrigin(Guid origin);
    IFluentEventMessageBuilder WithTimestamp(DateTime timestamp);
    IFluentEventMessageBuilder WithAuthor(Guid authorId);
    IFluentEventMessageBuilder WithChannel(string channel);
    IFluentEventMessageBuilder WithEventType(string eventType);
    IFluentEventMessageBuilder WithUserEvent(UserEvent userEvent);
    IFluentEventMessageBuilder WithTransactionEvent(TransactionEvent transactionEvent);
    IEventMessage Build();
    void Reset();
}
