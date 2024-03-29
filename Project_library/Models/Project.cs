﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_library.Models
{
    public class Projectt
    {
        public int Id { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public bool IsActive { get; set; }
        public string? ShortName { get; set; }
        public string? LongName { get; set; }
        public int ClientId { get; set; }

        public Client? Client { get; set; }
        public string? Name { get; set; }

        public List<Bill> getbillList { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }

        public string Display
        {
            get
            {
                return ToString();
            }
        }

    }
}
