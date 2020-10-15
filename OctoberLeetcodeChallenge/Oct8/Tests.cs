using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct8
{
    class Tests
    {
        private Codec _encoder;
        private Codec _decoder;

        [SetUp]
        public void Setup()
        {
            _encoder = new Codec();
            _decoder = new Codec();
        }

        [Test]
        public void Test1()
        {
            var root = new TreeNode(4);

            var n1 = new TreeNode(1);
            var n2 = new TreeNode(2);
            var n3 = new TreeNode(3);
            var n7 = new TreeNode(7);

            root.left = n2;
            root.right = n7;

            n2.left = n1;
            n2.right = n3;


            var encodedString = _encoder.serialize(root);
            var newRoot = _decoder.deserialize(encodedString);
            Assert.Pass();
        }
    }
}
