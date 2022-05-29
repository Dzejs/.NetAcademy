// See https://aka.ms/new-console-template for more information
using RecipeBook;
using RecipeBook.Models;

var filePathIngredients = "./../../../CsvFiles/Ingredients.csv";
CsvReader readerIngredients = new CsvReader(filePathIngredients);

List<Ingredient> ingredients = readerIngredients.ReadAllIngredients();
foreach (var ingredient in ingredients)
{
    Console.WriteLine($"IngredientId: {ingredient.Id} Ingredient: {ingredient.Name} Unit: {ingredient.Unit} Quantity: {ingredient.QuantityAvailable}");
}

List<Recipe> recipes = JsonReader.ReadAllRecipes();
foreach (var recipe in recipes)
{
    Console.WriteLine($"Id: {recipe.Id} Name: {recipe.Name}");
}


// Test
var user = new User
{
    Id = new Guid("abb94692-1c6b-40e3-b1b1-7bd6282eb2e1"),
    FirstName = "asda",
    LastName = "ewq"
};

user.CreateRecipe("blabla", "aaaa", "sssss", 1, 2, 1);
user.CreateRecipe("bla", "ggggg", "aaaaa", 1, 2, 1);
user.CreateRecipe("blablabla", "vvvv", "bbbbb", 1, 2, 1);
user.CreateRecipe("qwe", "zzzz", "tttt", 1, 2, 1);

foreach(var recipe in user.RecipesSubmitted)
{
    Console.WriteLine($"{recipe.Name}");
}

user.UserSubmissions();
user.UserLevelOfExpertise();
