using AutoMapper;
using Persistence_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service_Layer.Services
{
    public abstract class BaseService
    {
        protected readonly IMapper _mapper;

        protected readonly IUnitOfWork _unitOfWork;

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
    }
}
