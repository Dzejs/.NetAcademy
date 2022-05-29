namespace RecipeBook.Helpers
{
    public static class IngredientMapper
    {
        public static string[] MapNameProperty(string[] parts)
        {
            List<string> temp = new List<string>();
            var text = "";
            foreach (var part in parts)
            {

                if (part.Contains('"') || part.Contains(" "))
                    text += part;

                if (part == "\"" || part.Contains('"') || part.Contains(' '))
                    continue;

                temp.Add(part);
            }
            temp.Add(text);

            return temp.ToArray();
        }
    }
}
