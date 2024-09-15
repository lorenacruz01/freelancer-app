﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.InputModels
{
    public class NewProjectInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public int FreelancerId { get; set; }
        public decimal TotalCost { get; set; }
    }
}
