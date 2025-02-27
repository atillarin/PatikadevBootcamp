﻿using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Interface
{
    public interface IInvoiceService : IGenericService<Invoice, DtoInvoice>
    {
        IQueryable InvoiceReport();
    }
}
