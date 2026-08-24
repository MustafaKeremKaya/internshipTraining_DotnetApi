using Core.Utilities.Results;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    internal interface IProductService
    {
        public IDataResult <List<Product>>GetAll();
        public IDataResult<List<Product>> GetAllByCategoryId(int Id);
        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        public IDataResult<List<ProductDetailDto>> GetProductDetails();
        public IDataResult<Product> GetById(int productId);
        public IResult Add(Product product);
    }
}