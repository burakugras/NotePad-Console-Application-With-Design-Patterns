using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    public abstract class Note
    {
        public TextColor Color { get; set; }
        public abstract string View();
    }
}
