using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct1
{
    public class Tests
    {
        RecentCounter _counter;
        [SetUp]
        public void Setup()
        {
            _counter = new RecentCounter();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, _counter.Ping(1));
            Assert.AreEqual(2, _counter.Ping(2));
            Assert.AreEqual(3, _counter.Ping(3));
            Assert.AreEqual(4, _counter.Ping(4));
            Assert.AreEqual(5, _counter.Ping(5));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, _counter.Ping(1));
            Assert.AreEqual(2, _counter.Ping(100));
            Assert.AreEqual(3, _counter.Ping(3001));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(1, _counter.Ping(1));
            Assert.AreEqual(2, _counter.Ping(100));
            Assert.AreEqual(3, _counter.Ping(3001));
            Assert.AreEqual(3, _counter.Ping(3002));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(1, _counter.Ping(1));
            Assert.AreEqual(2, _counter.Ping(2));
            Assert.AreEqual(3, _counter.Ping(3));
            Assert.AreEqual(4, _counter.Ping(100));
            Assert.AreEqual(5, _counter.Ping(3001));
            Assert.AreEqual(5, _counter.Ping(3002));
            Assert.AreEqual(5, _counter.Ping(3003));
            Assert.AreEqual(5, _counter.Ping(3004));
            Assert.AreEqual(6, _counter.Ping(3005));
            Assert.AreEqual(7, _counter.Ping(3006));
        }
    }
}