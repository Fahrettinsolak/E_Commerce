﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DtoLayer.CatalogDtos.FeatureSliderDtos
{
    public class UpdateFeatureSliderDto
    {
        public string FeatureSliderId { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
