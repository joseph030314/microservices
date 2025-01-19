﻿using OrderMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMicroservice.ApplicationCore.Contracts.IRepositories
{
    public interface IShoppingCartRepositoryAsync : IRepositoryAsync<ShoppingCart>
    {
        Task<IEnumerable<ShoppingCart>> GetShoppingCartsByCustomerIdAsync(int customerId);
    }
}
