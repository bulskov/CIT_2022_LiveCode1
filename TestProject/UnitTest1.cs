using LiveCode1;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void InitNumberWithValue()
        {
            var num = new Number(5);
            Assert.Equal(5, num.Value);
        }

        [Fact]
        public void AddTwoNumbers()
        {
            var n1 = new Number(5);
            var n2 = new Number(3);

            var n3 = n1 + n2;

            Assert.Equal(8, n3.Value);
        }

        [Fact]
        public void AddANumberAndAnInteger()
        {
            var n1 = new Number(5);
            var n2 = 3;

            var n3 = n1 + n2;

            Assert.Equal(8, n3.Value);
        }
    }
}