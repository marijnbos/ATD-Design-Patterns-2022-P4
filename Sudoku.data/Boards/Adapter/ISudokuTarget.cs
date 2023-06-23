using Sudoku.data.Cells.@abstract;

namespace Sudoku.data.Boards.Adapter;

public interface ISudokuTarget
{
    List<List<ProductCell>> CreateBoard(string Inputcells);
    public List<string> DivideIntoPairs(string input);
    public List<int> GetGroups(List<string> pairs);
    List<char> GetCells(List<string> pairs);
}