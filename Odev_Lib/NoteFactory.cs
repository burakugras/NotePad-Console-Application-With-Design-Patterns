using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    public static class NoteFactory
    {
        public static ITextNoteBuilder GetTextNote(string header)
        {
            return new TextNoteBuilder(header);
        }
        public static IListNoteBuilder GetListNote()
        {
            return new ListNoteBuilder();
        }
        public static ITableNoteBuilder GetTableNote()
        {
            return new TableNoteBuilder();
        }
    }
}
