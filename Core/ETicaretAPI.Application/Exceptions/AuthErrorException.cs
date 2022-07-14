using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Exceptions
{
    public class AuthErrorException : Exception
    {
        public AuthErrorException():base("Kimlik doğrulama hatası")
        {
        }

        public AuthErrorException(string? message) : base(message)
        {
        }

        public AuthErrorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
