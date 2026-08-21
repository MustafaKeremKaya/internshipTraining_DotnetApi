using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    internal interface IProductService
    {
        List <Product> GetAll();
        List <Product> GetAllByCategoryId(int Id);
        List <Product> GetAllByUnitPrice(decimal min, decimal max);
        List <ProductDetailDto> GetAllByProductDetails();

    }
}