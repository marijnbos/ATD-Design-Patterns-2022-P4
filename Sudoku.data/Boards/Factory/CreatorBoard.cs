using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;

namespace Sudoku.data.Boards.Factory;

public abstract class CreatorBoard
{
    public static Dictionary<string, Type> boardTypes = new();

    protected CreatorBoard()
    {
        try
            {
                if(boardTypes.Count == 0)
                    LoadClasses("Sudoku.data.Boards");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        
    }
    
    public abstract Board factorMethod(string cells, string type, SudokuDisplayMode sudokuDisplayMode);
    
    private static void LoadClasses(string namespacePath)
    {
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            foreach (var type in assembly.GetTypes().Where(t => t.Namespace == namespacePath))
            {
                
                if (type.IsClass && type.IsSubclassOf(typeof(Board)))
                {
                    
                    boardTypes.Add(type.Name, type);
                }
            }
        }
    }
}