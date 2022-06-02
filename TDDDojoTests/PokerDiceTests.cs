using NUnit.Framework;
using System;
using TDDDojo;

namespace TDDDojoTests
{
    [TestFixture]
    public class PokerDiceTests
    {
        [Test]
        public void PokerHandReturnsString()
        {
            // Arrange
            var pokerDice = new PokerDice();
            int[] results = new int[5];

            // Act
            var _result = pokerDice.PokerHand(
                results);

            // Assert
            Assert.IsInstanceOf<string>(_result);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4})]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6})]
        [TestCase(new int[] { })]
        public void PokerHandInvalidArrayException(int[] array)
        {
            var pokerDice = new PokerDice();
            int[] results = array;

            Assert.Throws<ArgumentException>(() => pokerDice.PokerHand(results));
        }

        [Test]
        [TestCase(new int[] { 0, 2, 3, 4, 5})]
        [TestCase(new int[] { 1, 2, 3, 4, 5})]
        [TestCase(new int[] { 475, 0, 0, 0, 0})]
        public void PokerHandArrayWrongNumbersException(int[] array)
        {
            // Arrange
            var pokerDice = new PokerDice();
            int[] results = array;

            // Act
            var _result = pokerDice.PokerHand(
                results);

            // Assert
            Assert.Throws<ArgumentException>(() => pokerDice.PokerHand(results));
        }
    }
}
