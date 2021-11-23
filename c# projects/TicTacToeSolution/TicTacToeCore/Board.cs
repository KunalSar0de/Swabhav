using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
    public class Board
    {     
        public Cell[] _cells=new Cell[9];        

        public Board()
        {
            
        }
        public int CellCountCheck()
        {           
            return _cells.Length;
        }

        public Cell[] InitializeBoard()
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                 _cells[i] = new Cell();                
            }
            return _cells;
        }
        public bool CheckBoardValues()
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                InitializeBoard();
                if (_cells[i].GetMark == MarkType.EMPTY)
                {
                    return true;
                }
            }
            return false;
        }
        public void MarkCellValueOnBoard(int position,MarkType mark)
        {
            InitializeBoard();
            for (int i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new Cell();
                _cells[position].MarkCell(mark);
            }
        }
    }
}
