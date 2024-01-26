using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    class TextNoteFactory : INoteFactory

    {
        public INoteBuilder Create()
        {
            return new TextNoteBuilder("");
        }
    }
}
