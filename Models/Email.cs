﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmailService.Models
{
    public class Email
    {
        [Required]
        public string To { get; set; }
        [Required]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }
    }
}
