using System;
using System.Collections.Generic;
using System.Text;

namespace _04._04._2022Bashir_sTask.Utility.MyException
{
    class NotAvailableException : Exception
    {
        public NotAvailableException() : base("Gonderdiyiniz id-e uygun otaq bosh deyil !!!")
        {}
        public NotAvailableException(string message) : base(message)
        { }

    }
}
