﻿namespace SuperSimpleFactory.Models
{
    public class JapaneseRestaurantB : IRestaurant
    {
        public string Name { get; set; }
        public Cuisine Cuisine { get; set; }
        public RestaurantType RestaurantType { get; set; }
    }
}