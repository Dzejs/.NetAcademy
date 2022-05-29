namespace RecipeBook.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<RecipesOwned> Recipes { get; set; }
        public List<Recipe> RecipesSubmitted { get; set; } = new List<Recipe>();

        public void CreateRecipe(string name, string instuctions, string notes, int quantity, int preperingTime, float skillLevel)
        {
            RecipesSubmitted.Add(new Recipe
            {
                Name = name,
                Instructions = instuctions,
                Notes = notes,
                Quantity = quantity,
                PreperingTime = preperingTime,
                SkillLevel = skillLevel,
                UserId = Id
            });
        }
        public void UserSubmissions()
        {
            foreach(var recipe in RecipesSubmitted)
            {
                Console.WriteLine($"Name: {recipe.Name} PreperationTime: {recipe.PreperingTime} Quantity: {recipe.Quantity}");
            }
        }

        public void UserLevelOfExpertise()
        {
            float levelOfExpertise = 0;
            foreach (var recipe in RecipesSubmitted)
            {
                levelOfExpertise += recipe.SkillLevel;
            }

            Console.WriteLine($"User: {FirstName} has {levelOfExpertise} level of expertise!");
        }
    }
}
