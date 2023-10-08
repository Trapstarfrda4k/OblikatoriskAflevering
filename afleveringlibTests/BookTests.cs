using Microsoft.VisualStudio.TestTools.UnitTesting;
using OblikatoriskAflevering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace OblikatoriskAflevering.Tests
{
    [TestClass()]
    public class BookTests
    {
        private Book bookOne = new Book { Id= 1, Title= "Furkan", Price= 120 };
        private Book bookTwo = new Book { Id = 2, Title = "Dirican", Price = 1120 };
        private Book bookThree = new Book { Id = 3, Title = "Zealand", Price = 1333 };
        private Book bookFour = new Book { Id = 4, Title = "Roskilde", Price = -2 };
        private Book bookFive = new Book { Id = 5, Title = "Ko", Price = 220 };
        [TestMethod()]
        public void ToStringTest()
        {
            string str = bookOne.ToString();
            Assert.AreEqual("{Id=1, Title=Furkan, Price=120}", str);
        }

        [TestMethod()]
        public void validationTitleTest()
        {
            bookOne.validationTitle();
            Assert.ThrowsException<ArgumentException>(() => bookFive.validationTitle());
        }

        [TestMethod()]
        public void validationPriceTest()
        {
            bookOne.validationPrice();
            Assert.ThrowsException<ArgumentException>(() => bookThree.validationPrice());
            Assert.ThrowsException<ArgumentException>(() => bookFour.validationPrice());


        }
        [TestMethod()]
        public void validateTest()
        {
            bookOne.validate();
        }
    }
}