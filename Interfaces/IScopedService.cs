using System;

namespace DependencyInjection
{
    public interface IScopedService
    {
        Guid GetOperationId();
    }
}
