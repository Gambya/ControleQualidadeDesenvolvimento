using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortalQualidade.Domain.Entities;

namespace PortalQualidade.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTests
    {
        public string Nome { get; set; }
        public string EMail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmaPassword { get; set; }
        public string Departamento { get; set; }
        public bool Nivel { get; set; }
        public bool Flag { get; set; }

        public UsuarioTests()
        {
            Nome = "Roberto";
            EMail = "robertolopesramos@gmail.com";
            Login = "Beto";
            Password = "123456";
            ConfirmaPassword = "123456";
            Departamento = "Desenvolvimento";
            Nivel = false;
            Flag = false;
        }

        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void UsuarioNomeObrigatorio()
        {
            new Usuario("", EMail, Login, Password, ConfirmaPassword,Departamento, Nivel, Flag);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UsuarioEmailObrigatorio()
        {
            new Usuario(Nome, null, Login, Password, ConfirmaPassword, Departamento, Nivel, Flag);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UsuarioLoginObrigatorio()
        {
            new Usuario(Nome, EMail, "", Password, ConfirmaPassword, Departamento, Nivel, Flag);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UsuarioPasswordObrigatorio()
        {
            new Usuario(Nome, EMail, Login, "", ConfirmaPassword, Departamento, Nivel, Flag);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UsuarioConfirmaPasswordObrigatorio()
        {
            new Usuario(Nome, EMail, Login, Password, "", Departamento, Nivel, Flag);
        }
        [TestMethod]
        public void UsuarioNewNome()
        {
            var usuario = new Usuario(Nome, EMail, Login, Password, ConfirmaPassword, Departamento, Nivel, Flag);
            Assert.AreEqual(Nome, usuario.Nome);
        }
        [TestMethod]
        public void UsuarioNewEmail()
        {
            var usuario = new Usuario(Nome, EMail, Login, Password, ConfirmaPassword, Departamento, Nivel, Flag);
            Assert.AreEqual(EMail, usuario.EMail.EMail);
        }
        [TestMethod]
        public void UsuarioNewLogin()
        {
            var usuario = new Usuario(Nome, EMail, Login, Password, ConfirmaPassword, Departamento, Nivel, Flag);
            Assert.AreEqual(Login, usuario.Login);
        }
        [TestMethod]
        public void UsuarioNewDepartamento()
        {
            var usuario = new Usuario(Nome, EMail, Login, Password, ConfirmaPassword, Departamento, Nivel, Flag);
            Assert.AreEqual(Departamento, usuario.Departamento);
        }
    }
}
