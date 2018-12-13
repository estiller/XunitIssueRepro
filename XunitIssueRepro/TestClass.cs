using Xunit;

namespace XunitIssueRepro
{
    public class TestClass
    {
        [Fact]
        public void Fact_TestClassNotDisplayedCorrectly()
        {
        }

        [Theory]
        [InlineData("Hello")]
        public void Theory_TestClassDisplayedCorrectly(string data)
        {
        }
    }
}
