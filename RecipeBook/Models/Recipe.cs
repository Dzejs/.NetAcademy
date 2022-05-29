namespace RecipeBook.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
        public float SkillLevel { get; set; }
        public int PreperingTime { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<RecipesOwned> Users { get; set; }
        public List<IngredientsUsed> Ingredients { get; set; }
    }
}
