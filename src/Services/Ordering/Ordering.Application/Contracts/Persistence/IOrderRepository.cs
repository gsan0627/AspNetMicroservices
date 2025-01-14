﻿using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string username);        
    }
}
