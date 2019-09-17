using System;
using Lib.Collections;
using Xunit;

namespace Lib.Tests
{
    public class UnitTest1
    {
        [Trait("Category", "CategoryA")]
        [Fact(DisplayName = "PriorityQueue")]
        public void ReturnFalseGivenValueOf1()
        {
            var _sample = new PriorityQueue();
            var result = _sample.IsEven(2);

            Assert.True(result, "1 should not be even");
        }
    }
}
