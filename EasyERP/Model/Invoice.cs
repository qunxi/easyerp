﻿namespace EasyERP.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Invoice
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

        [Required]
        public bool Processing { get; set; }

        [Required]
        public bool Processed { get; set; }

        #region Foreign Keys

        public string OrderId { get; set; }

        public Order Order { get; set; }

        #endregion Foreign Keys
    }
}