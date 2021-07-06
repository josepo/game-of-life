namespace GameOfLife
{
   public class GameFactory
   {
      public static Game From(int[,] map)
      {
         int rows = map.GetLength(0);
         int cols = map.GetLength(1);

         Cell[,] cells = new Cell[rows, cols];

         for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
               bool isAlive = (map[i, j] == 1);

               cells[i, j] = new Cell(isAlive);
            }

         return new Game(cells);
      }
   }
}