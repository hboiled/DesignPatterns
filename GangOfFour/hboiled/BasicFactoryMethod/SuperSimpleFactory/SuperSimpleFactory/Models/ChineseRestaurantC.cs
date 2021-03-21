﻿namespace SuperSimpleFactory.Models
{
    public class ChineseRestaurantC : IRestaurant
    {
        public string Name { get; set; }
        public Cuisine Cuisine { get; set; }
        public RestaurantType RestaurantType { get; set; }
    }
}