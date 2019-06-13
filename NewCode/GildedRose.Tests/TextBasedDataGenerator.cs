namespace GildedRose.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class TextBasedDataGenerator
    {
        public static IReadOnlyList<string> GenerateLines()
        {
            var items = new List<Item>
            {
                new Item
                {
                    Name = "+5 Dexterity Vest",
                    SellIn = 10,
                    Quality = 20
                },
                new Item
                {
                    Name = "Aged Brie",
                    SellIn = 2,
                    Quality = 0
                },
                new Item
                {
                    Name = "Elixir of the Mongoose",
                    SellIn = 5,
                    Quality = 7
                },
                new Item
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = 0,
                    Quality = 80
                },
                new Item
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = -1,
                    Quality = 80
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item
                {
                    Name = "Conjured Mana Cake",
                    SellIn = 3,
                    Quality = 6
                }
            };

            var app = new GildedRose(items);

            const int DaysCount = 31;
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < DaysCount; i++)
            {
                stringBuilder.AppendLine("-------- day " + i + " --------");
                stringBuilder.AppendLine("name, sellIn, quality");

                foreach (var item in items)
                {
                    stringBuilder.AppendLine($"{item.Name}, {item.SellIn}, {item.Quality}");
                }

                stringBuilder.AppendLine(string.Empty);
                app.UpdateQuality();
            }

            return stringBuilder.ToString().Split(Environment.NewLine);
        }
    }
}