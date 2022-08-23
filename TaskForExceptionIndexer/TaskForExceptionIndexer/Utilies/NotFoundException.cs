using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForExceptionIndexer.Utilies
{
    class NotFoundException:Exception
    {
        public NotFoundException():base("This id not found")
        {

        }
    }
}
