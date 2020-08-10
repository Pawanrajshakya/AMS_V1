using System;
using System.Collections.Generic;
using System.Text;

namespace Service_Layer.Interfaces
{
    public interface IServiceManager
    {
        IGroupService Group { get; }
    }
}
