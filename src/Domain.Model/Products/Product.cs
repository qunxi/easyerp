﻿namespace Domain.Model.Products
{
    using System;
    using System.Collections.Generic;
    using Domain.Model.Factory;
    using Domain.Model.Stores;
    using Infrastructure.Domain.Model;

    public class Product : BaseEntity, IAggregateRoot
    {
        public Product()
        {
            Stores = new List<Store>();
            ProductPrices = new List<ProductPrice>();
        }

        public string Name { get; set; }

        public string ItemNo { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public int StockQuantity { get; set; }

        public string Gtin { get; set; }

        public decimal Price { get; set; }

        public decimal ProductCost { get; set; }

        public decimal Weight { get; set; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public bool Deleted { get; set; }

        public bool Published { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<ProductStatistic> ProduceRecord { get; set; }

        public virtual ICollection<MaterialStatisitc> MaterialComsumptions { get; set; }

        public virtual ICollection<Store> Stores { get; set; }

        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}