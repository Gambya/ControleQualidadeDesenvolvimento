using System;
using System.Text.RegularExpressions;
using PortalQualidade.Helpers.Resource;

namespace PortalQualidade.Helpers
{
    public class Guard
    {
        public static void IsEmailValid(string email)
        {
            if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                throw new Exception(Errors.InvalidEmail);
        }
        public static void ForNullOrEmpty(string value, string msgErro)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new Exception(msgErro);
            }
        }
    }
}
