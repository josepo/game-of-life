using Xunit;

namespace GameOfLife.Tests
{
    public class MapTest
    {
        [Fact]
        public void CellWithOneAliveNeighboursDies()
        {
           Map map = new Map(new int[,]
           {
              { 0, 0, 0 },
              { 0, 1, 0 },
              { 0, 1, 0 }
           });

           map.Run();

           Assert.False(map.Get(1, 1).Alive);
        }
    }
}
