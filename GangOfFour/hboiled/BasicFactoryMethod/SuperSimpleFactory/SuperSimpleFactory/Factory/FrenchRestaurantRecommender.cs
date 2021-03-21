using SuperSimpleFactory.Models;

namespace SuperSimpleFactory.Factory
{
    public class FrenchRestaurantRecommender : RestaurantRecommender
    {
        public override IRestaurant GetRestaurant(RestaurantType type)
        {
            IRestaurant restaurant = null;

            switch (type)
            {
                case RestaurantType.Classic:
                    restaurant = new FrenchRestaurantA();
                    break;
                case RestaurantType.Modern:
                    restaurant = new FrenchRestaurantB();
                    break;
                case RestaurantType.Fusion:
                    restaurant = new FrenchRestaurantC();
                    break;
            }

            return restaurant;
        }
    }
}