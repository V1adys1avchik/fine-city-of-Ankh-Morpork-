using System;
using NUnit.Framework;

namespace Ankh_Morpork.UnitTests
{
    public class Tests
    {

        [Test]
        public void Killed_WhenCalled_SetPlayerAliveIsFalse()
        {
            var player = new Player();

            player.Killed();

            Assert.AreEqual(false, player.Alive);
        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(7)]
        [TestCase(11)]
        public void AddMoney_PassPositiveNumber_AddMoneyToBalance(double d)
        {
            var player = new Player(0);

            player.AddMoney(d);

            Assert.AreEqual(d,player.Money);
        }

        [Test]
        [TestCase(-2)]
        [TestCase(-10)]
        public void AddMoney_PassNegativeNumber_ThrowArgumentException(double d)
        {
            var player = new Player(10);

            Assert.Throws<ArgumentException>(() => player.AddMoney(d));
        }

        [Test]
        [TestCase(-2)]
        [TestCase(-10)]
        public void GetMoney_PassNegativeNumber_ThrowArgumentException(double d)
        {
            var player = new Player(10);

            Assert.Throws<ArgumentException>(() => player.GetMoney(d));
        }

        [Test]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(5)]
        [TestCase(15)]
        public void GetMoney_EnoughMoney_ReturnsTrue(double d)
        {
            var player = new Player(50);

            var res = player.GetMoney(d);

            Assert.AreEqual(50-d,player.Money);
            Assert.True(res);
        }

        [Test]
        [TestCase(15)]
        [TestCase(11)]
        [TestCase(20)]
        public void GetMoney_NotEnough_ReturnsFalse(double d)
        {
            var player = new Player(10);

            var res = player.GetMoney(d);

            Assert.False(res);
        }
    }
}