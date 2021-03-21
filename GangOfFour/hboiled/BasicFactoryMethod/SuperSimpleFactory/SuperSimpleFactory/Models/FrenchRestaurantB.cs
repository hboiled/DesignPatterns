namespace SuperSimpleFactory.Models
{
    public class FrenchRestaurantB : IRestaurant
    {
        public string Name { get; set; }
        public Cuisine Cuisine { get; set; }
        public RestaurantType RestaurantType { get; set; }
    }
}