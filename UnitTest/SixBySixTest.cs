using Sudoku.data.Boards;
using Sudoku.data.Boards.Enum;
using Xunit;

namespace UnitTest
{
    public class SixBySixTest
    {
        private string Cells { get; set; }
        private SixBySix _sixBySix;
        private SudokuDisplayMode _sudokuDisplayMode = SudokuDisplayMode.Assist;

        public SixBySixTest()
        {
            Cells = "640200051000364002500436000640006025";
        }

        [Fact]
        public void CreateBoard_ValidInput_ReturnsCorrectBoard()
        {
            // Arrange
            _sixBySix = new SixBySix(Cells, _sudokuDisplayMode);

            // Act
            var board = _sixBySix.CreateBoard(Cells);

            // Assert
            Assert.Equal(6, board.Count);
            Assert.Equal(6, board[0].Count);
        }

        [Fact]
        public void CreateBoard_InvalidInput_ThrowsException()
        {
            // Arrange
            _sudokuDisplayMode = SudokuDisplayMode.Assist;
            Cells = "";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new SixBySix(Cells, _sudokuDisplayMode));
        }

        [Fact]
        public void Copy_Validinput_ReturnsCopyOfBoard()
        {
            // Arrange
            _sixBySix = new SixBySix(Cells, _sudokuDisplayMode);

            // Act
            var copy = _sixBySix.copy();

            // Assert
            Assert.Equivalent(copy.Cells, _sixBySix.Cells);
        }

        [Fact]
        public void Init_InvokesSolver_ReturnsSolvedBoard()
        {
            // Arrange
            _sixBySix = new SixBySix(Cells, _sudokuDisplayMode);

            // Act
            _sixBySix.init();

            // Assert
            Assert.NotEqual(_sixBySix.Cells, _sixBySix.SolvedBoard.Cells);
        }

    }
}