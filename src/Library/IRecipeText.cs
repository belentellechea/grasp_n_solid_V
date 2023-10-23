/*
para eliminar la dependencia entre la clase ConsolePrinter con la clase Recipe, se debe generar una abstracción entre ellas 
con respecto al método que ambas implementan. Para esto, se aplica el principio DIP (Dependency Inversion Principle)
*/

namespace Full_GRASP_And_SOLID
{
    public interface IRecipeText
    {
        string GetRecipeText (Recipe recipe);
    }
}