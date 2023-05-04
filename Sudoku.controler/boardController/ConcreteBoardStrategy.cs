using Sudoku.data.Boards;

namespace Sudoku.controler.Strategy;

public class ConcreteBoardStrategy : IBoardStrategy
{
    public void Exectute(SudokuTypes board)
    {
        switch (board)
        {
            //make builder for each enum
            case SudokuTypes.FourByFour:
                throw new NotImplementedException();
            case SudokuTypes.SixBySix:
                throw new NotImplementedException();
            case SudokuTypes.NineByNine:
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