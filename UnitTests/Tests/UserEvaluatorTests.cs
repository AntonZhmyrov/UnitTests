using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnitTests.Controllers;

namespace Tests
{
    [TestFixture]
    public class UserEvaluatorTests
    {
        private UserEvaluator _userEvaluator;

        [SetUp]
        public void Initialize()
        {
            _userEvaluator = new UserEvaluator();
        }

        [TestCase("Anton", "12345", ExpectedResult = true)]
        [TestCase("Danyl", "54321", ExpectedResult = true)]
        [TestCase("Lilya", "myPassword", ExpectedResult = true)]
        [TestCase("Andrey", "$ZAAd7", ExpectedResult = true)]
        public bool Exists_CorrectUsers_ReturnsTrue(string userName, string userPassword)
        {
            return _userEvaluator.Exists(userName, userPassword);
        }

        [TestCase("AntoN", "12345", ExpectedResult = false)]
        [TestCase("anyl", "54321", ExpectedResult = false)]
        [TestCase("Lila", "myPassword", ExpectedResult = false)]
        [TestCase("drey", "$ZAAd7", ExpectedResult = false)]
        public bool Exists_IncorrectUserNames_ReturnsFalse(string userName, string userPassword)
        {
            return _userEvaluator.Exists(userName, userPassword);
        }

        [TestCase("Anton", "1245", ExpectedResult = false)]
        [TestCase("Danyl", "654321", ExpectedResult = false)]
        [TestCase("Lilya", "yPassword", ExpectedResult = false)]
        [TestCase("Andrey", "$$$ZAAd7", ExpectedResult = false)]
        public bool Exists_IncorrectUserPasswords_ReturnsFalse(string userName, string userPassword)
        {
            return _userEvaluator.Exists(userName, userPassword);
        }
    } 
}
