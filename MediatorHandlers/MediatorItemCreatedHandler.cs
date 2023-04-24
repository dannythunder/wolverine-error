using Messages.Mediator;

namespace MediatorHandlers;

public class MediatorItemCreatedHandler
{
    public void Handle(MediatorItemCreated @event)
    {
        Console.WriteLine("You created a new item with id " + @event.Id);
    }
}