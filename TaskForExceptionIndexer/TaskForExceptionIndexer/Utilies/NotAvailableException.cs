using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForExceptionIndexer.Utilies
{
    class NotAvailableException:Exception
    {
        public NotAvailableException():base("This room not available cause is reserved")
        {

        }
    }
}
