﻿namespace EasyERP.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ExpenseType
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(32)]
        public string ExpenseTypeId { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Timestamp]
        [Required]
        public byte[] Created { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required]
        public string CreateBy { get; set; }

        [Timestamp]
        [Required]
        public byte[] Updated { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required]
        public string Updatedy { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(255)]
        public string Description { get; set; }

        public bool IsInvoiced { get; set; }

        #region Foreign Keys

        public string TaxCategoryId { get; set; }

        [ForeignKey("TaxCategoryId")]
        public TaxCategory TaxCategory { get; set; }

        public string ProductCategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; }

        #endregion Foreign Keys
    }
}