using System;
using SuperSimpleFactory.Factory;
using SuperSimpleFactory.Models;

namespace SuperSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantRecommender cnRecommender = new ChineseRestaurantRecommender();
            RestaurantRecommender jpRecommender = new JapaneseRestaurantRecommender();

            IRestaurant cnRestaurant = cnRecommender.GetRestaurant(RestaurantType.Classic);
            cnRecommender.RecommendRestaurant(cnRestaurant);

            IRestaurant jpRestaurant = jpRecommender.GetRestaurant(RestaurantType.Modern);
            jpRecommender.RecommendRestaurant(jpRestaurant);
        }
    }
}
