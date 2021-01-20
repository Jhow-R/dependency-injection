using System;

namespace DependencyInjection
{
    public interface ISingletonService
    {
        Guid GetOperationId();
    }
}
