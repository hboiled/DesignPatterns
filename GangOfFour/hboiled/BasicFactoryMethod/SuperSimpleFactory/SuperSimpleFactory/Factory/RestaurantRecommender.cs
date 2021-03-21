using System;
using System.Collections.Generic;
using System.Text;
using SuperSimpleFactory.Models;

namespace SuperSimpleFactory.Factory
{
    public abstract class RestaurantRecommender
    {
        public abstract IRestaurant GetRestaurant(RestaurantType type);

        public void RecommendRestaurant(IRestaurant restaurant)
        {
            Console.WriteLine($"Hello! { restaurant.Name } is good.");
        }
    }
}
