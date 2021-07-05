using System;

namespace GameOfLife
{
   class Program
   {
      static void Main(string[] args)
      {
         Map map = new Map(new int[,]
         {
            { 0, 1, 0, 0 },
            { 1, 1, 0, 1 },
            { 0, 0, 0, 1 }
         });
         
         Console.WriteLine(map);
      }
   }
}
