using System;

namespace DependencyInjection
{
    public interface ITransientService
    {
        Guid GetOperationId();
    }
}
