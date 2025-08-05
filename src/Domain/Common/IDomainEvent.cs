namespace Domain.Common;

public interface IDomainEvent : INotification
{
    DateTimeOffset OccurredOn => DateTimeOffset.UtcNow;
}