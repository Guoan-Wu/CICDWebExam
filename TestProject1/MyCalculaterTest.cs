using CICDWebExam;

namespace TestProject1
{
    public class MyCalculaterTest
    {
        [Fact]
        public void AddSucceed()
        {
            Assert.True(3 == MyCalculater.Add(1, 2));
        }

        [Theory]
        [InlineData(1,2,-3)]
        [InlineData(-1,1,2)]
        [InlineData(3,0,5)]
        public void AddFailed(int x, int y, int z)
        {
            Assert.True(z != MyCalculater.Add(x, y));
        }
    }
}