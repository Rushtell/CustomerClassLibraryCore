﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClassLibraryCore
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }

        public List<Address> Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<Note> Note { get; set; }

        [Column("TotalPurchasesAmount")]
        public decimal Money { get; set; }
    }
}
