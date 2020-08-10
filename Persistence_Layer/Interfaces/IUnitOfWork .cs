using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence_Layer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGroupRepository Group { get; }

        int Complete();
    }
}
