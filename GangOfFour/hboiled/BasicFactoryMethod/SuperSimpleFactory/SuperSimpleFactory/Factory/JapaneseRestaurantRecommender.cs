using SuperSimpleFactory.Models;

namespace SuperSimpleFactory.Factory
{
    public class JapaneseRestaurantRecommender : RestaurantRecommender
    {
        public override IRestaurant GetRestaurant(RestaurantType type)
        {
            IRestaurant restaurant = null;

            switch (type)
            {
                case RestaurantType.Classic:
                    restaurant = new JapaneseRestaurantA();
                    break;
                case RestaurantType.Modern:
                    restaurant = new JapaneseRestaurantB() { Name = "Generic Japanese Restaurant B"};
                    break;
                case RestaurantType.Fusion:
                    restaurant = new JapaneseRestaurantC();
                    break;
            }

            return restaurant;
        }
    }
}