﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reponsitories.Interface
{
    public interface IOrderRepository
    {
        public Task<bool> Add(Order order);
        public Task<bool> CheckDateOrder(int id,DateTime startDate,DateTime endDate);
    }
}
