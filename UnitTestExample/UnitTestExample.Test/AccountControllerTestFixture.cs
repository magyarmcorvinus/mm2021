using Moq;
using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Abstractions;
using UnitTestExample.Controllers;
using UnitTestExample.Entities;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [Test,
        TestCase("abcd1234", false),
        TestCase("irf@uni-corvinus", false),
        TestCase("irf.uni-corvinus.hu", false),
        TestCase("irf@uni-corvinus.hu", true)]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //Arrange
            var accoutController = new AccountController();
            //Act
            var actualResult = accoutController.ValidateEmail(email);
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        //                    "A jelszó legalább 8 karakter hosszú kell legyen, csak az angol ABC betűiből és számokból állhat, és tartalmaznia kell legalább egy kisbetűt, egy nagybetűt és egy számot.");

        [Test,
        TestCase("abcdabcd", false),
        TestCase("IRFIRFIRF1", false),
        TestCase("irfirfirf1", false),
        TestCase("Abc1", false),
        TestCase("Abc1Abc1", true)]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            var accoutController = new AccountController();
            //Act
            var actualResult = accoutController.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [
            Test,
            TestCase("irf@uni-corvinus.hu", "Abcd1234"),
            TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            //Arrange
            var accoutController = new AccountController();
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Returns<Account>(a => a);
            //Act
            accoutController.AccountManager = accountServiceMock.Object;

            var actualResult = accoutController.Register(email, password);

            //Assert
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
            accountServiceMock.Verify(m => m.CreateAccount(actualResult), Times.Once);
        }
        [Test,
        TestCase("irf@uni-corvinus", "Abcd1234"),
        TestCase("irf.uni-corvinus.hu", "Abcd1234")]
        public void TestRegisterValidateException(string email, string password)
        {
            //Arrange
            var accoutController = new AccountController();
            Exception e = new ApplicationException(); ;
            //Act
            try
            {
                
                try
                {
                    var actualResult = accoutController.Register(email, password);

                }
                catch (Exception xx)
                {
                    e = xx;
                    throw;
                }
                Assert.Fail();
            }
            catch (Exception Exxx)
            {
                Assert.IsInstanceOf<ValidationException>(e);
            }


        }


    }
}
