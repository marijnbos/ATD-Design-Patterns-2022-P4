using Sudoku.data.Boards;

namespace Sudoku.controler.Strategy;

public class ConcreteBoardStrategy : IBoardStrategy
{
    public void Exectute(SudokuTypes board)
    {
        switch (board)
        {
            //make builder for each enum
            case SudokuTypes.fourByFour:
                throw new NotImplementedException();
            case SudokuTypes.sixBySix:
                throw new NotImplementedException();
            case SudokuTypes.nineByNine:
                throw new NotImplementedException();
            case SudokuTypes.Samurai:
                throw new NotImplementedException();
            case SudokuTypes.Jigsaw:
                throw new NotImplementedException();
            default:
                return;
        }
        
    }
}