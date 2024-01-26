using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    class ListNoteBuilder : IListNoteBuilder
    {
        ListNote listNote;
        public ListNoteBuilder()
        {
            listNote = new ListNote();
        }
        public IListNoteBuilder AddItem(string item)
        {
            listNote.Items.Add(item);
            return this;
        }

        public Note Create()
        {
            return listNote;
        }

        public IListNoteBuilder IsOrdered(bool order = true)
        {
            listNote.IsOrdered = order;
            return this;
        }

        public IListNoteBuilder SetCharacter(UnorderedListTypes listType)
        {
            if (listNote.IsOrdered)
            {
                throw new Exception("Sıralı listede karakter kullanılamaz");
            }
            listNote.ListType = (char)listType;
            return this;
        }

        public IListNoteBuilder SetFormat(OrderedListTypes listType)
        {
            if (!listNote.IsOrdered)
            {
                throw new Exception("Sıralı listede format seçilemez");
            }
            listNote.ListType = (char)listType;
            return this;
        }
    }
}
