using Autofac;
using Framework.Application;

namespace Framework.Autofac;
public class AutofacCommandBus : ICommandBus
{
    private readonly ILifetimeScope _scope;
    public AutofacCommandBus(ILifetimeScope scope)
    {
        _scope= scope;
    }
    public async Task Dispatch<T>(T command) where T : ICommand
    {
        var handlers = _scope.Resolve<IEnumerable<ICommandHandler<T>>>();

        foreach (var commandHandler in handlers)
        {
            await commandHandler.Handle(command);
        }
    }
}