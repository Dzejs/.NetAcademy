namespace RecipeBook.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int QuantityAvailable { get; set; }
        public int Unit { get; set; }
        public List<IngredientsUsed> Recipes { get; set; }
    }
}
