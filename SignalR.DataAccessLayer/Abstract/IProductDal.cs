﻿using SignalRApi.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        public int ProductCount();
        public int ProductCountByCategoryNameHamburger();
        public int ProductCountByCategoryNameDrink();
        decimal ProductPriceAvg();
        string ProductPriceByMax();
        string ProductPriceByMin();
        decimal ProductPriceByHamburger(); // hamburgerin ortalama fiyatını alabilmek için





    }
}
