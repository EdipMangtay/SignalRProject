﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.ViewModels.Dtos.TestimonialDto
{
    public class ResultTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImgUrl { get; set; }
        public bool Status { get; set; }
    }
}
