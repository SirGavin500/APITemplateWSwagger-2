using System;
using System.Collections.Generic;

namespace APITemplateWSwagger.Services
{
    public class RestaurantPickerService
    {
        private readonly Random random = new();

        private readonly Dictionary<string, List<string>> restaurants = new()
        {
            { "italian", new() { "Luigi's", "Pasta Palace", "Roma Dine", "Venice Cafe", "Mamma Mia", "Trattoria Roma", "Pizza Bella", "Bella Pasta", "Little Italy", "Olive Garden" } },
            { "chinese", new() { "Golden Wok", "Dragon Express", "Panda Garden", "Great Wall", "Lucky House", "Red Lantern", "China Town", "Wok This Way", "Mandarin Delight", "Szechuan Spice" } },
            { "mexican", new() { "El Sombrero", "Taco Loco", "Casa Bonita", "Fiesta Mexicana", "Burrito Bros", "Aztec Grill", "Cantina Mexicana", "La Fiesta", "Margarita's", "Sombrero Fiesta" } }
        };

        public string Pick(string category)
        {
            category = category.ToLower();

            if (!restaurants.ContainsKey(category))
                return "Invalid category";

            var list = restaurants[category];
            return list[random.Next(list.Count)];
        }
    }
}
