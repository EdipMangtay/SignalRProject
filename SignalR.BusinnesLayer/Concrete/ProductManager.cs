﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR.BusinnesLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalRApi.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            _productDal.Add(entity);


        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);

        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);

        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();

        }

        public List<Product> TGetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();

        }

		public int TProductCount()
		{
			return _productDal.ProductCount(); // IProductDal'daki ProductCount metotunu çağırdık bu sayede IProductDal implemente edildiğinde bu metot kullanılacak
		}

        public int TProductCountByCategoryNameDrink()
        {
            return _productDal.ProductCountByCategoryNameDrink();

        }

        public int TProductCountByCategoryNameHamburger()
        {
            return _productDal.ProductCountByCategoryNameHamburger();
        }

        public decimal TProductPriceAvg()
        {
            return _productDal.ProductPriceAvg();
        }

        public decimal TProductPriceByHamburger()
        {
            return _productDal.ProductPriceByHamburger();
        }

        public string TProductPriceByMax()
        {
            return _productDal.ProductPriceByMax();
        }

        public string TProductPriceByMin()
        {
            return _productDal.ProductPriceByMin();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);

        }
    }
}
