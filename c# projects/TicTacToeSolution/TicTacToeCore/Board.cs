
namespace TicTacToeCore
{
    public class Board
    {     
        public Cell[] _cells=new Cell[9];       

        public Board()
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new Cell();
            }
        }
        public int CellCountCheck()
        {           
            return _cells.Length;
        }

        public bool CheckBoardEmpty()
        {
            for(int i=0;i<_cells.Length;i++)
            {
                if (_cells[i].GetMark == MarkType.EMPTY)
                    return true;
            }
            return false;
        }
        public bool CheckBoardIsFull()
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                if (_cells[i].GetMark == MarkType.EMPTY)
                    return false;
            }
            return true;
        }

        public void MarkCellAtPosition(int position,MarkType type)
        {
            _cells[position-1].MarkCell(type);
        }
        public MarkType GetMarkAtSpecificLocation(int location)
        {
            return _cells[location-1].GetMark;
        }

        public Cell[] GetAllCells
        {
            get
            {
                return _cells;
            }
        }
    }
}
