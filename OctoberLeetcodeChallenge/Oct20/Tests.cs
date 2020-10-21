using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct20
{
    class Tests
    {
        private Solution _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void Test1()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.neighbors.Add(n2);
            n1.neighbors.Add(n3);
            n1.neighbors.Add(n4);

            n2.neighbors.Add(n1);
            n2.neighbors.Add(n6);

            n3.neighbors.Add(n1);
            n3.neighbors.Add(n6);
            n3.neighbors.Add(n7);

            n4.neighbors.Add(n1);
            n4.neighbors.Add(n5);
            n4.neighbors.Add(n6);

            n5.neighbors.Add(n4);

            n6.neighbors.Add(n2);
            n6.neighbors.Add(n3);
            n6.neighbors.Add(n4);

            n7.neighbors.Add(n3);
            n7.neighbors.Add(n5);

            var newRoot = _solution.CloneGraph(n1);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);


            n1.neighbors.Add(n2);
            n1.neighbors.Add(n4);

            n2.neighbors.Add(n1);
            n2.neighbors.Add(n3);

            n3.neighbors.Add(n2);
            n3.neighbors.Add(n4);

            n4.neighbors.Add(n1);
            n4.neighbors.Add(n3);

            var newRoot = _solution.CloneGraph(n1);
            Assert.Pass();
        }
    }
}
