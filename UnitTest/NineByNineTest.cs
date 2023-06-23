using Sudoku.data.Boards;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Position;

namespace UnitTest
{
    public class NineByNineTest
    {
        private string Cells { get; set; }
        private NineByNine _nineByNine;
        private SudokuDisplayMode _sudokuDisplayMode = SudokuDisplayMode.Assist;

        public NineByNineTest()
        {
            Cells = "530070000600195000098000060800060003400803001700020006060000280000419005000080079";
        }

        [Fact]
        public void CreateBoard_ValidInput_ReturnsCorrectBoard()
        {
            // Arrange
            _nineByNine = new NineByNine(Cells, _sudokuDisplayMode);

            // Act
            var board = _nineByNine.CreateBoard(Cells);

            // Assert
            Assert.Equal(9, board.Count);
            Assert.Equal(9, board[0].Count);
        }

        [Fact]
        public void SolveBoard_UnsolvableBoard_ThrowsException()
        {
            // Arrange
            _sudokuDisplayMode = SudokuDisplayMode.Assist;
            Cells = "";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new NineByNine(Cells, _sudokuDisplayMode));
        }

        [Fact]
        public void Move_ValidInput_ReturnsCorrectMove()
        {
            // Arrange
            _nineByNine = new NineByNine(Cells, _sudokuDisplayMode);
            var move = new Pos(1, 1);

            // Act
            _nineByNine.move(move);

            // Assert
            Assert.Equal(1, _nineByNine.SelectedCell.X);
            Assert.Equal(1, _nineByNine.SelectedCell.Y);
        }


        [Fact]
        public void CopyCells_Validinput_ReturnsCopyOfCells()
        {
            // Arrange
            _nineByNine = new NineByNine(Cells, _sudokuDisplayMode);

            // Act
            var board = _nineByNine.CreateBoard(Cells);
            var copy = _nineByNine.CopyCells();

            // Assert
            Assert.Equivalent(board, copy);
        }


        [Fact]
        public void CopyCells_ThrowsExecption_ReturnsCopyOfCells()
        {
            // Arrange

            _nineByNine = new NineByNine(Cells, _sudokuDisplayMode);

            // Act
            var board = _nineByNine.CreateBoard(Cells);
            _nineByNine.Cells = null;

            // assert
            Assert.Throws<Exception>(() => _nineByNine.CopyCells());
        }


        [Fact]
        public void Solver_ValidInput_ReturnsCorrectMove()
        {
            // Arrange
            _nineByNine = new NineByNine(Cells, _sudokuDisplayMode);

            // Act
            var newboard = _nineByNine.SolvedBoard;

            // Assert
            Assert.NotEqual(newboard.Cells, _nineByNine.Cells);
            Assert.NotEqual(newboard.Cells[0][3].Value, _nineByNine.Cells[0][3].Value);
            Assert.Equal(newboard.Cells[0][0].Value, _nineByNine.Cells[0][0].Value);
        }
    }
}