using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortalQualidade.Domain.ValueObjects;
using PortalQualidade.Helpers;

namespace PortalQualidade.Domain.Tests.ValueObjects
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void PasswordNullOrEmpty()
        {
            Guard.ForNullOrEmpty("","Password Inválido.");
        }
    }
}
