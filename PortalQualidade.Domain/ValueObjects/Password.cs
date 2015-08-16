using PortalQualidade.Domain.Resources;
using PortalQualidade.Helpers;

namespace PortalQualidade.Domain.ValueObjects
{
    public class Password
    {
        public string Senha { get; private set; }

        protected Password(){}

        public Password(string senha)
        {
            SetPassword(senha);
        }

        private void SetPassword(string senha)
        {
            Guard.ForNullOrEmpty(senha, Errors.InvalidPassword);
            Senha = Guard.Encrypt(senha);
        }
    }
}
