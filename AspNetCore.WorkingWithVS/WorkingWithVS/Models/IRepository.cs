﻿using System.Collections.Generic;

namespace WorkingWithVS.Models
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product p);
    }
}
