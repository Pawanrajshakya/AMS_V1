using Service_Layer.Interfaces;

namespace Service_Layer.Services
{
    public class ServiceManager : IServiceManager
    {
        public IGroupService Group { get; private set; }

        public ServiceManager(IGroupService group)
        {
            this.Group = group;
        }
    }
}
