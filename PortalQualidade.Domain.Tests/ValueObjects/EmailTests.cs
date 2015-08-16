using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortalQualidade.Domain.ValueObjects;

namespace PortalQualidade.Domain.Tests.ValueObjects
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void EmailEmBranco()
        {
            var email = new Email("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmailNull()
        {
            var email = new Email(null);
        }

        [TestMethod]
        public void EmailValido()
        {
            var endereco = "robertolopesramos@gmail.com";
            var email = new Email(endereco);
            Assert.AreEqual(endereco,email.EMail);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmailInvalido()
        {
            var email = new Email("sdsdsdsdsdsdsfsfs");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmailErroMaxLeght()
        {
            var endereco = "robertolopesramos@gmail.com";
            while (endereco.Length < Email.EmailMaxLength+1)
            {
                endereco = endereco + "robertolopesramos@gmail.com";
            }
            new Email(endereco);
        }

    }
}
