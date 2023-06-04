using Sudoku.data.Boards.Enum;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board.Factory;

public class ViewBoardFactory : CreatorViewBoard
{
    public override SudokuBoardView factorMethod(SudokuDisplayMode sudokuDisplayMode, SudokuTypes type, List<List<CellView>> cells)
    {
        return type switch
        {
            SudokuTypes.Jigsaw => new JigsawBoardDrawingStrategy(sudokuDisplayMode, type.ToString(), cells),
            SudokuTypes.Samurai => new SamuraiBoardDrawingStrategy(sudokuDisplayMode, type.ToString(), cells),
            SudokuTypes.FourByFour => new FourByFourBoardDrawingStrategy(sudokuDisplayMode, type.ToString(), cells),
            SudokuTypes.SixBySix => new SixBySixDrawingStrategy(sudokuDisplayMode, type.ToString(), cells),
            SudokuTypes.NineByNine => new NineByNineBoardDrawingStrategy(sudokuDisplayMode, type.ToString(), cells),
            _ => throw new NotImplementedException()
        };
    }
}