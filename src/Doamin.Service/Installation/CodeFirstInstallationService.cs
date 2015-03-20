﻿namespace Doamin.Service.Installation
{
    using Domain.Model;
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;

    public class CodeFirstInstallationService : IInstallationService
    {
        public readonly IRepository<Order> OrderRepository;

        public readonly IRepository<Product> ProducrRepository;

        public CodeFirstInstallationService(IRepository<Product> productRepository, IRepository<Order> orderRepository)
        {
            this.ProducrRepository = productRepository;
            this.OrderRepository = orderRepository;
        }

        public void InstallData()
        {
            this.InstallProducts();
        }

        private void InstallProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Cost = 5,
                    Description = "pancake description",
                    Name = "pancake",
                    Origin = "china",
                    Price = 10,
                    Upc = "690193900",
                    Volume = 1.0
                },
                new Product
                {
                    Id = 2,
                    Cost = 6,
                    Description = "pancake description",
                    Name = "cupcake",
                    Origin = "china",
                    Price = 15,
                    Upc = "690193901",
                    Volume = 1.0
                },
                new Product
                {
                    Id = 3,
                    Cost = 7,
                    Description = "cup description",
                    Name = "cup",
                    Origin = "china",
                    Price = 18,
                    Upc = "690193902",
                    Volume = 1.0
                },
                new Product
                {
                    Id = 4,
                    Cost = 9,
                    Description = "pan description",
                    Name = "pan",
                    Origin = "china",
                    Price = 20,
                    Upc = "690193903",
                    Volume = 1.0
                },
                new Product
                {
                    Id = 5,
                    Cost = 25,
                    Description = "cake description",
                    Name = "cake",
                    Origin = "china",
                    Price = 40,
                    Upc = "690193901",
                    Volume = 1.0
                }
            };

            products.ForEach(p => this.ProducrRepository.Add(p));
            this.ProducrRepository.Update();
        }

        private void InstallOrder()
        {
        }
    }
}