﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSimpleFactory.Models
{
    public class FrenchRestaurantA : IRestaurant
    {
        public string Name { get; set; }
        public Cuisine Cuisine { get; set; }
        public RestaurantType RestaurantType { get; set; }
    }
}
