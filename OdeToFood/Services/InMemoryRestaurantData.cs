using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1,Name="Cafe Coffee Day" },
                new Restaurant{Id=2,Name="Goodluck Cafe" },
                new Restaurant{Id=3,Name="Iraanee Cafe" },
            };
        }

        public Restaurant Add(Restaurant restaurant)
        {
            var id = _restaurants.Max(_r => _r.Id);
            restaurant.Id = id+1;
            _restaurants.Add(restaurant);
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(_r => _r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(_r=>_r.Name);
        }
    }
}
