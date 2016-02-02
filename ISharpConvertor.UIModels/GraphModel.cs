﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.UIModels
{
    public class GraphModel
    {
        public DateTime Date { get; set; }
        public double Rate { get; set; }
        public string Currency { get; set; }
        public string Bank { get; set; }
    }
}