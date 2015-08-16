using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PortalQualidade.Domain.Resources;
using PortalQualidade.Helpers;
using PortalQualidade.Helpers.Resource;

namespace PortalQualidade.Domain.ValueObjects
{
    public class Email
    {
        public const int EmailMaxLength = 254;
        public string EMail { get; private set; }

        protected Email() {}

        public Email(string email)
        {
            Guard.ForNullOrEmptyDefaultMessage(email, "Email");
            Guard.StringLength("Email", email, EmailMaxLength);
            if (!IsEmailValid(email))
                throw new Exception(Errors.InvalidEmail);
            this.EMail = email;
        }
        public static bool IsEmailValid(string email)
        {       
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
    }
}
