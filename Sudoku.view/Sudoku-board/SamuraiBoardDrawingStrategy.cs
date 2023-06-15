using Sudoku.data.Boards.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board
{
    public class SamuraiBoardDrawingStrategy : SudokuBoardView
    {
        public SamuraiBoardDrawingStrategy(Board board) : base(board)
        {
        }

        public override void Draw()
        {
            // Start iterating over each row in the Sudoku
            for (int row = 0; row < Size; row++)
            {
               
                
                // Start iterating over each column in the Sudoku
                for (int col = 0; col < Size; col++)
                {
                    
                    // Get the cell view for the current cell
                    CellView cellView = GetCell(row, col);

                    // If it's a NotaCell, print 'x' for the spaces, but also add the vertical line after every 3 cells
                    if (cellView._cell == 'x')
                    {
                        for(int i = 0; i < 9; i++)
                        {
                            Console.Write("x");

                        }
                    }
                    else
                    {
                        // Draw the cell
                        cellView.Draw();

                        // Add a vertical line after each cell
                        if ((col + 1) % 3 == 0 && col < Size - 1)
                        {
                            Console.Write("|");
                        }
                    }
                }

                // Print a new line after each row is complete
                Console.WriteLine();
                // Add a horizontal line after every 3 rows, but not at the end
                if ((row + 1) % 3 == 0 && row < Size - 1)
                {
                    Console.WriteLine(new String('-', Size * 9 + 8));  // adjust the number of '-' as needed
                }
            }
        }








        
    }
}