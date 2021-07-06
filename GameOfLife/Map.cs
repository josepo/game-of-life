using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
   public class Map
   {
      private Cell[,] Cells { get; set; }
      private int MaxRow { get; set; }
      private int MaxCol { get; set; }

      public Map(int[,] map)
      {
         MaxRow = map.GetLength(0) - 1;
         MaxCol = map.GetLength(1) - 1;

         Cells = new Cell[MaxRow + 1, MaxCol + 1];

         for (int i = 0; i <= MaxRow; i++)
            for (int j = 0; j <= MaxCol; j++)
            {
               bool isAlive = (map[i, j] == 1);

               Cells[i, j] = new Cell(isAlive);
            }
      }

      public void Run()
      {
         Cell[,] newCells = new Cell[MaxRow + 1, MaxCol + 1];

         for (int i = 0; i <= MaxRow; i++)
            for (int j = 0; j <= MaxCol; j++)
            {
               int alive = Neighbors(i, j).Count(n => n.Alive);

               newCells[i, j] = new Cell(alive >= 2);
            }

         Cells = newCells;
      }

      private List<Cell> Neighbors(int i, int j)
      {
         List<Cell> neighbors = new List<Cell>();

         int rowStart = (i == 0) ? 0 : (i - 1);
         int rowEnd = (i == MaxRow) ? MaxRow : (i + 1);

         int colStart = (j == 0) ? 0 : (j - 1);
         int colEnd = (j == MaxCol) ? MaxCol : (j + 1);

         for (int row = rowStart; row <= rowEnd; row++)
            for (int col = colStart; col <= colEnd; col++)
            {
               if ((row != i) || (col != j))
               {
                  Cell cell = Get(row, col);

                  neighbors.Add(cell);
               }
            }

         return neighbors;
      }

      public Cell Get(int i, int j)
      {
         return Cells[i, j];
      }

      public override string ToString()
      {
         string result = "";

         for (int i = 0; i <= MaxRow; i++)
         {
            result += "\n";

            for(int j = 0; j <= MaxCol; j++)
               result += Cells[i, j] + "  ";
         }

         return result;
      }
   }
}