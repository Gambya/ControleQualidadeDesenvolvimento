using PortalQualidade.Domain.Resources;
using PortalQualidade.Helpers;

namespace PortalQualidade.Domain.ValueObjects
{
    public class Password
    {
        public const int PasswordMaxLenght = 20;
        public const int PasswordMinLenght = 6;
        public string Senha { get; private set; }

        protected Password(){}

        public Password(string senha, string confirmaSenha)
        {
            SetPassword(senha, confirmaSenha);
        }

        private void SetPassword(string senha, string confirmaPassword)
        {
            Guard.ForNullOrEmpty(senha, Errors.InvalidPassword);
            Guard.ForNullOrEmpty(confirmaPassword, Errors.InvalidConfirmaPasswordNullOrEmpty);
            Guard.AreEqual(senha, confirmaPassword, Errors.InvalidConfirmaPassword);
            Guard.StringLength("Password", senha, PasswordMinLenght, PasswordMaxLenght);
            Senha = Guard.Encrypt(senha);
        }
    }
}
