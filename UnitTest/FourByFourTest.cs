using Sudoku.data.Boards;
using Sudoku.data.Boards.Enum;
using Xunit;

namespace UnitTest
{
    public class FourByFourTest
    {
        private string Cells { get; set; }
        private FourByFour _fourByFour;
        private SudokuDisplayMode _sudokuDisplayMode = SudokuDisplayMode.Assist;

        public FourByFourTest()
        {
            Cells = "0340400210030210";
        }

        [Fact]
        public void CreateBoard_ValidInput_ReturnsCorrectBoard()
        {
            // Arrange
            _fourByFour = new FourByFour(Cells, _sudokuDisplayMode);

            // Act
            var board = _fourByFour.CreateBoard(Cells);

            // Assert
            Assert.Equal(4, board.Count);
            Assert.Equal(4, board[0].Count);
        }

        [Fact]
        public void CreateBoard_InvalidInput_ThrowsException()
        {
            // Arrange
            _sudokuDisplayMode = SudokuDisplayMode.Assist;
            Cells = "";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new FourByFour(Cells, _sudokuDisplayMode));
        }

        [Fact]
        public void Copy_Validinput_ReturnsCopyOfBoard()
        {
            // Arrange
            _fourByFour = new FourByFour(Cells, _sudokuDisplayMode);

            // Act
            var copy = _fourByFour.copy();

            // Assert
            Assert.Equivalent(_fourByFour.Cells, copy.Cells); 
        }

        [Fact]
        public void Init_InvokesSolver_ReturnsSolvedBoard()
        {
            // Arrange
            _fourByFour = new FourByFour(Cells, _sudokuDisplayMode);

            // Act
            _fourByFour.init();

            // Assert
            Assert.NotEqual(_fourByFour.Cells, _fourByFour.SolvedBoard.Cells);
        }

    }
}