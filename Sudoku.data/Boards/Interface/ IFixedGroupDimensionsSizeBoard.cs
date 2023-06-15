using Sudoku.data.Boards.Enum;
using Sudoku.data.Cells.@abstract;

namespace Sudoku.data.Boards.Interface;

public interface IFixedGroupDimensionsSizeBoard
{
    int GroupHeight { get; }
    int GroupWidth { get; }
}