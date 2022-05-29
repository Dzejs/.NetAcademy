using RecipeBook.Helpers;
using RecipeBook.Models;

namespace RecipeBook
{
    public class CsvReader
    {
        private readonly string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<Ingredient> ReadAllIngredients()
        {
            var ingredients = new List<Ingredient>();

            using (var reader = new StreamReader(_csvFilePath))
            {
                reader.ReadLine();

                string csvLine;
                while ((csvLine = reader.ReadLine()) != null)
                {
                    ingredients.Add(ReadIngredientFromCsvLine(csvLine));
                }

                return ingredients;
            }
        }

        public Ingredient ReadIngredientFromCsvLine(string csvLine)
        {
            var parts = csvLine.Split(',');
            var id = "";
            var name = "";
            var quantityAvailable = 0;
            var unit = 0;

            if (parts.Length == 4)
            {
                id = parts[0];
                name = parts[1];
                quantityAvailable = int.Parse(parts[2]);
                unit = int.Parse(parts[3]);
            }
            else
            {
                id = parts[0];
                parts = IngredientMapper.MapNameProperty(parts);

                quantityAvailable = int.Parse(parts[1]);
                unit = int.Parse(parts[2]);
                name = parts[3].Replace("\"", null).Trim();
            }

            return new Ingredient { Id = Guid.Parse(id), Name = name, QuantityAvailable = quantityAvailable, Unit = unit };
        }
    }
}
