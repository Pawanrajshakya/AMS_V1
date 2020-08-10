using Persistence_Layer.Data;
using Persistence_Layer.Interfaces;
using Persistence_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence_Layer.Repository
{
    public class GroupRepository : Repository<Group>, IGroupRepository

    {

        public GroupRepository(DataContext dbContext) : base(dbContext)

        {

        }
    }
}
