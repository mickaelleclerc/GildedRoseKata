namespace GildedRose.Tests
{
    using System;
    using System.IO;
    using Xunit;

    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            var fileLines = File.ReadAllLines("ThirtyDays.txt");
            var generatedLines = TextBasedDataGenerator.GenerateLines();

            for (var i = 0; i < Math.Min(fileLines.Length, generatedLines.Count); i++)
            {
                Assert.Equal(fileLines[i], generatedLines[i]);
            }
        }
    }
}
