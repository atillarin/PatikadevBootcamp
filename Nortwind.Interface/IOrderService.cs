﻿using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Interface
{
    public interface IOrderService:IGenericService<Order,DtoOrder>
    {
        IQueryable OrderReport(int orderId);
    }
}
