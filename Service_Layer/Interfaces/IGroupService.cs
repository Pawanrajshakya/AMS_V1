using Service_Layer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service_Layer.Interfaces
{
    public interface IGroupService : IDeleteService,

   IAddService<GroupToSaveDto>,

   IUpdateService<GroupToEditDto>

    {



    }
}
