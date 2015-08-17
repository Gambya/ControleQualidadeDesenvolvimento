using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortalQualidade.Domain.ValueObjects;
using PortalQualidade.Helpers;

namespace PortalQualidade.Domain.Tests.ValueObjects
{
    [TestClass]
    public class PasswordTests
    {
        public Password Password { get; set; }

        public PasswordTests()
        {
            Password = new Password("123456", "123456");
        }
        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void PasswordNullOrEmpty()
        {
            Guard.ForNullOrEmpty("","Password Inválido.");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PasswordMinMaxLenght()
        {
            if (Password.Senha.Length < 6 || Password.Senha.Length > 20)
                throw new Exception("Password não pode ser menor que 6 caracters nem maior que 20 caracteres.");
        }
        [TestMethod]
        public void PasswordEIgualAoConfirmaPassword()
        {
            Assert.AreEqual(Guard.Encrypt("123456"),Password.Senha);
        }
    }
}
