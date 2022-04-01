using System;
using System.Collections.Generic;
using System.Text;

namespace _04._04._2022Bashir_sTask.Utility.MyException
{
    class NotFoundException :Exception
    {
        public NotFoundException() : base("Gonderdiyiniz id-e uygun otaq tapilmadi !!!")
        {}
        public NotFoundException(string message) : base(message)
        {}
    }
}
