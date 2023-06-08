using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace UnitTest
{
    using System;
    using System.Collections.Generic;
    using Xunit;
}

namespace Sudoku.Tests
{
    public class NineByNineTests
    {
        [Fact]
        public void CreateBoard_ValidInput_ReturnsCorrectBoard()
        {
            // Arrange
            string cells = "530070000600195000098000060800060003400803001700020006060000280000419005000080079";
            var sudokuDisplayMode = SudokuDisplayMode.Assist;
            var nineByNine = new NineByNine(cells, sudokuDisplayMode);

            // Act
            var board = nineByNine.CreateBoard(cells);

            // Assert
            Assert.Equal(9, board.Count);
            Assert.Equal(9, board[0].Count);
            // Add more assertions to verify the correctness of the board creation
        }

        [Fact]
        public void SolveBoard_UnsolvableBoard_ThrowsException()
        {
            // Arrange
            string cells = "539979999600195000098000060800060003400803001700029996060000280000419005000080079";
            var sudokuDisplayMode = SudokuDisplayMode.Assist;

            // Act & Assert
            Assert.Throws<Exception>(() => new NineByNine(cells, sudokuDisplayMode));
        }

        // Add more unit tests for the NineByNine class as needed
    }

    

    public class BoardTests
    {
        public void setup()
        {
            
        }
        
        [Fact]
        public void CopyCells_Validinput_ReturnsCopyOfCells()
        {
            // Arrange
            string cells = "530070000600195000098000060800060003400803001700020006060000280000419005000080079";
            var sudokuDisplayMode = SudokuDisplayMode.Assist;
            var nineByNine = new NineByNine(cells, sudokuDisplayMode);

            // Act
            var board = nineByNine.CreateBoard(cells);
            var copy = nineByNine.CopyCells();

            // Assert
            Assert.Equivalent(board, copy);
        }
        [Fact]
        public void CopyCells_ThrowsExecption_ReturnsCopyOfCells()
        { 
            // Arrange
            string cells = "530070000600195000098000060800060003400803001700020006060000280000419005000080079";
            var sudokuDisplayMode = SudokuDisplayMode.Assist;
            var nineByNine = new NineByNine(cells, sudokuDisplayMode);
            
            // Act
            var board = nineByNine.CreateBoard(cells);
            nineByNine.Cells = null;

            // assert
            Assert.Throws<Exception>(() => nineByNine.CopyCells());
        }
       

        private class MockBoard : Board
        {
            public MockBoard(List<List<ProductCell>> cells) : base("", SudokuTypes.NineByNine, SudokuDisplayMode.Assist)
            {
                Cells = cells;
            }

            public override Board getSolvedBoard()
            {
                throw new NotImplementedException();
            }

            public override Board validateBoard()
            {
                throw new NotImplementedException();
            }

            public override IConcreteBoard copy()
            {
                throw new NotImplementedException();
            }

            public override List<List<ProductCell>> CreateBoard(string cells)
            {
                var board = new List<List<ProductCell>>();
                int group = 0;
                if (cells.Length != 81)
                    throw new Exception("Invalid board");
                

                for (int i = 0; i < 9; i++)
                {
                    var row = new List<ProductCell>();
                    for (int j = 0; j < 9; j++)
                    {
                        char cellValue = cells[i * 9 + j];
                        bool selected = (i == 0 && j == 0) ? true : false;
                        row.Add(new CellFactory().factorMethod(group, cellValue, selected,
                            (cellValue == '0') ? CellState.Empty : CellState.FilledSystem, new List<int>()));
                        group++;
                    }

                    board.Add(row);
                }

                return board;
            }

            public override void move(Pos move)
            {
                throw new NotImplementedException();
            }
        }
    }
}