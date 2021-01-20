using System;

namespace DependencyInjection
{
    public class OperationService :
        ITransientService,
        IScopedService,
        ISingletonService
    {

        private readonly Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetOperationId() => id;
    }
}
