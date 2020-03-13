﻿using System.Linq;
using Agathas.Storefront.Model.Products;

namespace Agathas.Storefront.Services.Cache.Specifications
{
    public class ProductIsInSizeSpecification : IProductSearchSpecification
    {
        private readonly int[] _sizeIds;

        public ProductIsInSizeSpecification(int[] sizeIds)
        {
            _sizeIds = sizeIds;
        }

        public bool IsSatisfiedBy(Product product)
        {
            if (_sizeIds.Count() > 0 )
                return _sizeIds.Any(s => product.Title.Products.Any(p => p.Size.Id == s));

            return true;
        }
    }
}