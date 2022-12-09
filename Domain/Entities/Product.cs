﻿using Domain.Common;
using Domain.ViewModel.Images;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public List<ProductImage> ProductImages { get; set; }
    }
}