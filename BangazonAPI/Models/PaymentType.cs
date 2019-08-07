﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BangazonAPI.Models
{
    public class PaymentType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public int AcctNumber { get; set; }

        public int CustomerId { get; set; }
    }
}
