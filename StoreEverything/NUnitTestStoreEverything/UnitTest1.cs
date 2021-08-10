using NUnit.Framework;
using StoreEverything.MethodsForNUnit;
using System;

namespace NUnitTestStoreEverything
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Food")]
        public void SetCategory_SetCategory_Food(string category)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(category);
            string actual = "Food";
            Assert.AreEqual(excepted, actual);
        }

        [Test]
        [TestCase("15212")]
        [TestCase("999")]
        public void SetCategory_SetCategory_isNotString(string category)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(category);
            string actual = "Is not a string";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("")]
        public void SetCategory_SetCategory_isEmpty(string category)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(category);
            string actual = "The field is empty";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("k")]
        [TestCase("kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk")]
        public void SetCategory_SetCategory_isLengthOrShort(string category)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(category);
            string actual = "Invalid number of characters";
            Assert.AreEqual(excepted, actual);
        }

        [Test]
        [TestCase("Pavel")]
        public void SetName_SetName_Pavel(string name)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetName(name);
            string actual = "Pavel";
            Assert.AreEqual(excepted, actual);
        }

        [Test]
        [TestCase("15212")]
        [TestCase("999")]
        public void SetName_SetName_isNotString(string name)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetName(name);
            string actual = "Is not a string";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("")]
        public void SetName_SetName_isEmpty(string name)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetName(name);
            string actual = "The field is empty";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("k")]
        [TestCase("kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk")]
        public void SetName_SetName_isLengthOrShort(string category)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(category);
            string actual = "Invalid number of characters";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("Victory Avenue")]
        public void SetAdress_SetAdress_VictoryAvenue(string adress)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetAdress(adress);
            string actual = "Victory Avenue";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("")]
        public void SetAdress_SetAdress_isEmpty(string adress)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetAdress(adress);
            string actual = "The field is empty";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("k")]
        [TestCase("kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk")]
        public void SetAdress_SetAdress_isLengthOrShort(string adress)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetAdress(adress);
            string actual = "Invalid number of characters";
            Assert.AreEqual(excepted, actual);
        }
        [TestCase("Minsk")]
        public void SetCity_SetCityy_City(string city)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(city);
            string actual = "Minsk";
            Assert.AreEqual(excepted, actual);
        }

        [Test]
        [TestCase("15212")]
        [TestCase("999")]
        public void SetCity_SetCity_isNotString(string city)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(city);
            string actual = "Is not a string";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("")]
        public void SetCity_SetCityy_isEmpty(string city)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(city);
            string actual = "The field is empty";
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase("k")]
        [TestCase("kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk")]
        public void SetCity_SetCity_isLengthOrShort(string city)
        {
            Controllers obj = new Controllers();
            string excepted = obj.SetCategory(city);
            string actual = "Invalid number of characters";
            Assert.AreEqual(excepted, actual);
        }

        [Test]
        [TestCase(1200)]
        [TestCase(300)]
        [TestCase(70)]
        public void Addition_Sum_SumPriceAndStartprice(double price)
        {
            Controllers obj = new Controllers();
            double excepted = Convert.ToDouble(obj.Addition(price));
            double actual = price + obj.startPrice;
            Assert.AreEqual(excepted, actual);
        }
        [Test]
        [TestCase(-1200)]
        [TestCase(-300)]
        [TestCase(-70)]
        public void Addition_Sum_NegativeAmount(double price)
        {
            Controllers obj = new Controllers();
            string excepted = obj.Addition(price);
            string actual = "You entered a negative amount";
            Assert.AreEqual(excepted, actual);
        }
    }
}