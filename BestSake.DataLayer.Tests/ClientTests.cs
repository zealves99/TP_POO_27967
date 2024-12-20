/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>19/12/2024 9:25:28 PM</date>
*	<description>Class with tests to the methods of the Client Class.</description>
**/

using Data_BestSale;
using Exceptions;

namespace BestSale.DataLayer.Tests
{
    [TestClass]
    public sealed class ClientTests
    {
        /// <summary>
        /// Test the constructor of client given a valid mobile number.
        /// </summary>
        [TestMethod]
        public void Constructor_ValidParameters_ClientCreationMobile()
        {
            //Arrange
            var name = "Jose Alves";
            var contact = "969696969";

            //Act
            var client = new Client(name, contact);

            //Assert
            Assert.AreEqual(name, client.Name);
            Assert.AreEqual(contact, client.Contact);
            Assert.AreNotEqual(0, client.ClientID);
        }

        [TestMethod]
        /// <summary>
        /// Test the constructor of client given a valid landline number.
        /// </summary>
        public void Constructor_ValidParameters_ClientCreationLandLine()
        {
            //Arrange
            var name = "Jose Alves";
            var contact = "253253253";

            //Act
            var client = new Client(name, contact);

            //Assert
            Assert.AreEqual(name, client.Name);
            Assert.AreEqual(contact, client.Contact);
            Assert.AreNotEqual(0, client.ClientID);
        }

        [TestMethod]
        /// <summary>
        /// Test the constructor of client given an invalid contact.
        /// </summary>
        public void Constructor_InvalidContact_ThrowsInvalidPhoneNumberException()
        {
            //Arrange
            var name = "Jose Alves";
            var invalidContact = "123456789";

            //Act & Assert
            try
            {
                var client = new Client(name, invalidContact);
                Assert.Fail("Expected InvalidPhoneNumberException not thrown");
            }
            catch (InvalidPhoneNumberException exception)
            {
                Assert.AreEqual("Invalid Phone Number", exception.Message);
            }
            


        }
    }
}
