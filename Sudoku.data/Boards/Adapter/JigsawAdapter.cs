using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;

namespace Sudoku.data.Boards.Adapter;

public class JigsawAdapter : ISudokuTarget
{
    public List<List<ProductCell>> CreateBoard(string Inputcells)
    {
        var cellGroups = DivideIntoPairs(Inputcells);
        var groups = GetGroups(cellGroups);
        var cells = GetCells(cellGroups);
        var board = new List<List<ProductCell>>();

        // Assuming groups and cells are correctly extracted
        for (int i = 0; i < 9; i++)
        {
            var row = new List<ProductCell>();
            for (int j = 0; j < 9; j++)
            {
                char cellValue = cells[i * 9 + j];
                bool selected = (i == 0 && j == 0) ? true : false;
                int group = groups[i * 9 + j];
                row.Add(new CellFactory().factorMethod(group, cellValue, selected, (cellValue == '0') ? CellState.Empty : CellState.FilledSystem, new List<int>()));

            }
            board.Add(row);
        }

        return board;
    }
    
    public List<string> DivideIntoPairs(string input)
    {
        var groups = new List<string>();
        var splitInput = input.Split('=');

        for (int i = 0; i < splitInput.Length; i ++)
        {
            var cellpar = splitInput[i].Split('J');
            string pair = cellpar[0] + cellpar[1] ;
            groups.Add(pair);
        }

        return groups;
    }



    public List<int> GetGroups(List<string> pairs)
    {
        var groups = new List<int>();

        foreach (var pair in pairs)
        {
            // The group is the second character of each pair
            groups.Add(int.Parse(pair[1].ToString()));
        }

        return groups;
    }

    public List<char> GetCells(List<string> pairs)
    {
        var cells = new List<char>();

        foreach (var pair in pairs)
        {
            // The cell is the first character of each pair
            cells.Add(pair[0]);
        }

        return cells;
    }

}