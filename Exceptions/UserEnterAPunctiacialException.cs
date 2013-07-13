using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    class UserEnterAPunctiacialException: ApplicationException
    {
        public UserEnterAPunctiacialException(String message) :
            base(message)
        {}
    }
}
