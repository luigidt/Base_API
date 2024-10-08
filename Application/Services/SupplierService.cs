﻿using Application.Interfaces.Services;
using Application.Services.Base;
using Domain.Interfaces.Entities.Base;
using Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Services
{
    public class SupplierService(IMediator mediator, ISupplierRepository genericRepository) : ServiceBase<ISupplierRepository, Supplier>(mediator, genericRepository), ISupplierService
    {
    }
}
