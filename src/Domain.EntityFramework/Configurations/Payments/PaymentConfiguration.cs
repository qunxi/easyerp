﻿namespace Domain.EntityFramework.Configurations.Payments
{
    using Domain.Model.Payments;
    using System.Data.Entity.ModelConfiguration;

    public class PaymentConfiguration : EntityTypeConfiguration<Payment>
    {
        public PaymentConfiguration()
        {
            HasKey(p => p.Id);
        }
    }
}