using System;
using System.Collections.Generic;
using MicroCenter.Domain.Entities;

namespace MicroCenter.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
