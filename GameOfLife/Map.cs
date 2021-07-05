namespace GameOfLife
{
   public class Map
   {
      private int[,] _map;

      public Map(int[,] map)
      {
         _map = map;
      }

      public void Run()
      {
         int[,] newMap = (int[,]) _map.Clone();

         for (int i = 0; i < newMap.GetLength(0); i++)
            for (int j = 0; j < newMap.GetLength(1); j++)
            {
               int alive = GetAliveNeighbors(i, j);

               newMap[i, j] = (alive < 2) ? 0 : 1;
            }

         _map = newMap;
      }

      private int GetAliveNeighbors(int i, int j)
      {
         int alive = 0;

         for (int r = i - 1; r <= i + 1; r++)
            for (int s = j - 1; s <= j + 1; s++)
            {
               if (
                  (r > 0) && (r < _map.GetLength(0)) &&
                  (s > 0) && (s < _map.GetLength(1)) && 
                  ((r != i) || (s != j)) &&
                  (_map[r, s] == 1))
               {
                  alive++;
               }
            }

         return alive;
      }

      public int Get(int i, int j)
      {
         return _map[i, j];
      }

      public override string ToString()
      {
         string result = "";

         for (int i = 0; i < _map.GetLength(0); i++)
         {
            result += "\n";

            for(int j = 0; j < _map.GetLength(1); j++)
               result += _map[i, j] + "  ";
         }

         return result;
      }
   }
}