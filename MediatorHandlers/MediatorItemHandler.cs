using Messages.Mediator;
using Messages.Mediator.Aggregate;

namespace MediatorHandlers;

public class MediatorItemHandler
{
    public static MediatorItemCreated Handle(
        MediatorCreateItemCommand command)
    {
        var item = new MediatorItem
        {
            Name = command.Name
        };

        return new MediatorItemCreated
        {
            Id = item.Id
        };
    }
}