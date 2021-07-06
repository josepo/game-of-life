using System;

namespace GameOfLife
{
   class Program
   {
      static void Main(string[] args)
      {
         Game game = GameFactory.From(new int[,]
         {
            { 0, 1, 0, 0 },
            { 1, 1, 0, 1 },
            { 0, 0, 0, 1 }
         });
         
         Console.WriteLine(game);
      }
   }
}
