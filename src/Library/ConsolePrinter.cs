using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter, IRecipeText
    {
        public void PrintRecipe(IRecipeText recipeText)
        {
            Console.WriteLine(recipeText.GetRecipeText());
        }
        public string GetRecipeText()
        {
            return "Receta a imprimir";
        }
    }
}