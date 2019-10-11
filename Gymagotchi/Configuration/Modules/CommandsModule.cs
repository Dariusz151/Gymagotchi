using Autofac;
using System;
using System.Linq;
using Gymagotchi.Requests.Common;

namespace Gymagotchi.Commands
{
    public class CommandsModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(x => x.IsAssignableTo<ICommandHandler>())
                .AsImplementedInterfaces();

            builder.Register<Func<Type, ICommandHandler>>(c =>
            {
                var ctx = c.Resolve<IComponentContext>();

                return t =>
                {
                    var handlerType = typeof(ICommandHandler<>).MakeGenericType(t);
                    return (ICommandHandler)ctx.Resolve(handlerType);
                };
            });

            builder.RegisterType<CommandsBus>()
                .AsImplementedInterfaces();
        }
    }
}
