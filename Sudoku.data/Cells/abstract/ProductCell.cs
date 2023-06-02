using Sudoku.data.Color;

namespace Sudoku.data
{
    //todo introduce composit pattern to group cells
    public abstract class ProductCell
    {
        private int group { get; }
        public abstract char value { get; set; }
        public abstract ColorEnum getCollor();
        protected ProductCell(int group)
        {
            this.group = group;
        }
    }
}