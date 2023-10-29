using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter, IRecipeText
    {
        public void PrintRecipe(IRecipeText recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetRecipeText());
        }

        public string GetRecipeText()
        {
            return "Receta a imprimir";
        }
    }
}