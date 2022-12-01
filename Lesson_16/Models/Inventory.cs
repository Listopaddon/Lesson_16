using Lesson_16.Models.Domain;
using System.Text.Json;

namespace Lesson_16.Models
{
    public class Inventory
    {
        public List<Product> products = new List<Product>();
        public Inventory(string jsonFile)
        {
            //string jsonString = File.ReadAllText(jsonFile);
            //products.Add(JsonSerializer.Deserialize<Product>(jsonString)!);
            products.Add(new Wood("Oak", 43, 2));
            products.Add(new Chemicals("Oil", 143, 22));
            products.Add(new Leather("Pig Skin", 423, 244));
        }
    }
}
