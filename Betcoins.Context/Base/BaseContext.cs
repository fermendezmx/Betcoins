using System.Data.Entity;

namespace Betcoins.Context.Base
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext() : base("name=BetcoinsConnection")
        {
        }
    }
}
