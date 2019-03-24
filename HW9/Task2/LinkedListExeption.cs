using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class LinkedListException: ApplicationException
    {
        public LinkedListException(string message) : base(message)
        {
        }
    }
}
