﻿namespace Gringotts.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class WizzardDeposit
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(60)]
        public string LastName { get; set; }
        
        [MaxLength(1000)]
        public string Notes { get; set; }
        
        [Required]
        [Range(1, 2147483647)]
        public int Age { get; set; }
        
        [MaxLength(100)]
        public string MagicWandCreator { get; set; }
        
        [Range(0, 32767)]
        public int MagicWandSize { get; set; }
        
        [MaxLength(20)]
        public string DepositGroup { get; set; }
        
        public DateTime DepositStartDate { get; set; }
        
        public decimal DepositAmount { get; set; }
        
        public decimal DepositInterest { get; set; }

        public double DepositCharge { get; set; }
        
        public DateTime DepositExpirationDate { get; set; }
        
        public bool IsDepositExpired { get; set; }
    }
}
