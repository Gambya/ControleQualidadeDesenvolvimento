using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalQualidade.Domain.ValueObjects
{
    public class Email
    {
        public const int EmailMaxLength = 254;
        public string EMail { get; private set; }

        protected Email() {}

        public Email(string email)
        {
            this.EMail = email;
        }
    }
}
