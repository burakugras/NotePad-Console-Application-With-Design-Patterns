using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    public interface ITextNoteBuilder:INoteBuilder
    {
        //ITextNoteBuilder SetHeader(string header);
        ITextNoteBuilder AddParagraph(string content);
        Note Create();
    }
}
