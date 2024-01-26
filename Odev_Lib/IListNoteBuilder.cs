using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    public interface IListNoteBuilder:INoteBuilder
    {
        IListNoteBuilder IsOrdered(bool order=true);
        IListNoteBuilder SetFormat(OrderedListTypes listTypes);
        IListNoteBuilder SetCharacter(UnorderedListTypes listType);
        IListNoteBuilder AddItem(string item);
        Note Create();
    }

    public enum OrderedListTypes
    {
        Number='1',
        Letter='a'
    }
    public enum UnorderedListTypes
    {
        Asteriks='*',
        Dot='.',
        Hyphen='-'
    }
}
