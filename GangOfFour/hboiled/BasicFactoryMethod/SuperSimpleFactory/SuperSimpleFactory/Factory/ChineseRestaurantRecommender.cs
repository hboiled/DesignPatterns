using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SuperSimpleFactory.Models;

namespace SuperSimpleFactory.Factory
{
    public class ChineseRestaurantRecommender : RestaurantRecommender
    {
        public override IRestaurant GetRestaurant(RestaurantType type)
        {
            IRestaurant restaurant = null;

            switch (type)
            {
                case RestaurantType.Classic: 
                    restaurant = new ChineseRestaurantA() { Name = "Generic Chinese Restaurant A"};
                    break;
                case RestaurantType.Modern:
                    restaurant = new ChineseRestaurantB();
                    break;
                case RestaurantType.Fusion:
                    restaurant = new ChineseRestaurantC();
                    break;
            }

            return restaurant;
        }
    }
}
