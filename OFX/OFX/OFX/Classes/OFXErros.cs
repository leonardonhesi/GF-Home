using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OFX.OFX.Classes
{
    class OFXErros : Exception
    {
        public OFXErros(String message) : base(message)
        {

        }
    }
}
