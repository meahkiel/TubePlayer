using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.Library.Shared.Exceptions
{
    public class HttpGetErrorException : Exception
    {
        public HttpGetErrorException(string message) : base($"Http internal error occured {message}")
        {
            
        }
    }
}
