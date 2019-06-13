namespace GildedRose.Tests
{
    using System.Collections.Generic;
    using Xunit;

    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "foo", SellIn = 0, Quality = 0 }
            };

            var app = new GildedRose(items);
            app.UpdateQuality();

            Assert.Equal("fixme", items[0].Name);
        }
    }
}