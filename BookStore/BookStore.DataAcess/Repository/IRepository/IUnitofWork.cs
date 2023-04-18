﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository.IRepository
{
    public interface IUnitofWork
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        IProducteRepository Product { get; }
        ICompanyRepository Company { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUser { get; }
		IOrderDetailRepository OrderDetail { get; }
		IOrderHeaderRepository OrderHeader { get; }

		void Save();
    }
}
