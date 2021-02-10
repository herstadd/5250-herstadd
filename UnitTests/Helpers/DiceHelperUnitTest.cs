﻿using System;
using System.Collections.Generic;
using System.Text;
using Mine.Models;
using NUnit.Framework;
using Mine.Helpers;

namespace UnitTests.Helpers
{
    [TestFixture]
    class DiceHelperUnitTest
    {
        [Test]
        public void RollDice_Invalid_Roll_Zero_Should_Return_Zero()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(0, 1);

            // Reset

            // Assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void RollDice_Valid_Roll_1_Dice_6_Should_Return_Between_1_and_6()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(1, 6);

            // Reset

            // Assert
            Assert.AreEqual(true, result >= 1);
            Assert.AreEqual(true, result <= 6);
        }

        [Test]
        public void RollDice_Invalid_Roll_Forced_1_Should_Return_1()
        {
            // Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForcedRandomValue = 1;

            // Act
            var result = DiceHelper.RollDice(1, 1);

            // Reset
            DiceHelper.ForceRollsToNotRandom = false;

            // Assert
            Assert.AreEqual(1, result);
        }

        // Template:
        // Arrange

        // Act

        // Reset

        // Assert

        [Test]
        public void RollDice_Valid_Roll_2_Dice_6_Should_Return_Between_2_and_12()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(2, 6);

            // Reset

            // Assert
            Assert.AreEqual(true, result >= 2);
            Assert.AreEqual(true, result <= 12);
        }

        [Test]
        public void RollDice_Invalid_Roll_0_Dice_10_Should_Return_Zero()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(0, 10);

            // Reset

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void RollDice_Invalid_Roll_1_Dice_0_Should_Return_Zero()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(1, 0);

            // Reset

            // Assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void RollDice_Valid_Roll_1_Dice_10_Fixed_5_Should_Return_5()
        {
            // Arrange
            DiceHelper.ForcedRandomValue = 5;
            DiceHelper.ForceRollsToNotRandom = true;

            // Act
            var result = DiceHelper.RollDice(1, 10);

            // Reset
            DiceHelper.ForcedRandomValue = 1;
            DiceHelper.ForceRollsToNotRandom = false;

            // Assert
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void RollDice_Valid_Roll_3_Dice_10_Fixed_5_Should_Return_15()
        {
            // Arrange
            DiceHelper.ForcedRandomValue = 5;
            DiceHelper.ForceRollsToNotRandom = true;

            // Act
            var result = DiceHelper.RollDice(3, 10);

            // Reset
            DiceHelper.ForcedRandomValue = 1;
            DiceHelper.ForceRollsToNotRandom = false;

            // Assert
            Assert.AreEqual(result, 15);
        }
    }
}
