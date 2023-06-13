using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;

namespace Sudoku.data.Boards.Factory;

public abstract class CreatorBoard
{
    public static Dictionary<string, Type> boardTypes = new();

    protected CreatorBoard()
    {
        
        //todo refactor this into a loadClasses method
        // if (boardTypes.Count == 0)
        // {
        //     boardTypes.Add(".jigsaw", typeof(Jigsaw));
        //     boardTypes.Add(".samurai", typeof(Samurai));
        //     boardTypes.Add(".4x4", typeof(FourByFour));
        //     boardTypes.Add(".9x9", typeof(NineByNine));
        //     boardTypes.Add(".6x6", typeof(SixBySix));
        // }
        
        
            try
            {
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