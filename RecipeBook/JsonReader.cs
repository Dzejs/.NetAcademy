using Newtonsoft.Json;
using RecipeBook.Models;

namespace RecipeBook
{
    public static class JsonReader
    {
        public static List<Recipe> ReadAllRecipes()
        {
            var recipies = new List<Recipe>();


            using (StreamReader r = new StreamReader("./../../../JsonFiles/Recipes.json"))
            {
                string json = r.ReadToEnd();
                RecipeData items = JsonConvert.DeserializeObject<RecipeData>(json);
                recipies = MapRecipes(items);
            }

            return recipies;
        }

        public static List<Recipe> MapRecipes(RecipeData items)
        {
            List<Recipe> recipies = new List<Recipe>();
            foreach (var item in items.Data)
            {
                recipies.Add(new Recipe
                {
                    Id = Guid.Parse(item[0]),
                    Name = item[1],
                    Instructions = item[2],
                    Quantity = int.Parse(item[3]),
                    Notes = item[4],
                    SkillLevel = float.Parse(item[5]),
                    PreperingTime = int.Parse(item[6])
                });
            }

            return recipies;
        }
    }
}
