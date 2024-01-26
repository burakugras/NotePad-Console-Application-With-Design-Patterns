using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    public interface ITableNoteBuilder:INoteBuilder
    {
        ITableNoteBuilder AddColumn(string columnsHeader);
        ITableNoteBuilder AddRow(params string[] data);
        Note Create();

    }
}
