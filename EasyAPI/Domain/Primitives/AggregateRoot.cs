namespace Domain.Primitives;

public abstract class AggregateRoot
{
    // State of Domain Events
    private readonly List<DomainEvents> _domainEvents = new();

    public ICollection<DomainEvents> GetDomainEvents() => _domainEvents;

    protected void Raise(DomainEvents domainEvents)
    {
        _domainEvents.Add(domainEvents);
    }
}
