using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Personal_Ex1.Entities.Exceptions
{
    internal class DomainsException : ApplicationException
    {
        public DomainsException(string message) : base(message)
        {
        }
    }
}