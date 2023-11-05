﻿using System.ComponentModel.DataAnnotations;

namespace SMS1._0TransactionServices.Models
{
    public class CommonTransaction
    {
        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        [Required]
        public bool Enabled { get; set; }
    }
}
