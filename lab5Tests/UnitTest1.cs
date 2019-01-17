using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab5.Candies;
using lab5.Gift;
using System.Collections.Generic;

namespace lab5Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWeight()
        {
            var candies = new List<Candy>() { new Vzletnaya(), new Vzletnaya(), new Alenka(), new Korowka() };
            var gift = new Gift();
            gift.Add(new Vzletnaya());
            gift.Add(new Vzletnaya());
            gift.Add(new Korowka());
            gift.Add(new Alenka());

            double expectedCandiesWeight = 0;
            candies.ForEach((candy) => expectedCandiesWeight += candy.Weight);

            Assert.AreEqual(gift.Weight, expectedCandiesWeight);

            gift.Add(new Alenka());

            Assert.AreNotEqual(gift.Weight, expectedCandiesWeight);

        }

        [TestMethod]
        public void TestSearch()
        {
            var gift = new Gift();
            gift.Add(new Vzletnaya());
            gift.Add(new Vzletnaya());
            gift.Add(new Korowka());
            gift.Add(new Alenka());

            var sugar = new Vzletnaya().SugarWeight;

            var foundCandies = gift.FindBySugar(sugar, sugar);

            Assert.IsTrue(foundCandies.TrueForAll((candy) => candy is Vzletnaya));
        }
    }
}
