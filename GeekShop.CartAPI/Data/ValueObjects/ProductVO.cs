﻿using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShop.CartAPI.Data.ValueObjects
{
    [Table("product")]
    public class ProductVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }

    }
}
