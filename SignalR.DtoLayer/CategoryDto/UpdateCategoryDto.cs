﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.CategoryDto
{
    public class UpdateCategoryDto
    {
        public int Categoryid { get; set; }
        public string CategoryName { get; set; }

        public string Status { get; set; }
    }
}