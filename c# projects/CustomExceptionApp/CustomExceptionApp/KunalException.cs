using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionApp
{
    class KunalException:Exception
    {
        public KunalException() :base()
        {

        }
        public KunalException(string messege):base(messege)
        {

        }
    }
}
