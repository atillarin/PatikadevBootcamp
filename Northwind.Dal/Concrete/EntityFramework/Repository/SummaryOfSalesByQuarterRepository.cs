﻿using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class SummaryOfSalesByQuarterRepository : GenericRepository<SummaryOfSalesByQuarter>, ISummaryOfSalesByQuarterRepository
    {
        public SummaryOfSalesByQuarterRepository(DbContext context):base(context)
        {

        }
        public IQueryable SummaryOfSalesByQuarterReport()
        {
            throw new NotImplementedException();
        }
    }
}
