using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    class TableNoteBuilder : ITableNoteBuilder
    {
        TableNote tableNote;
        public TableNoteBuilder()
        {
            tableNote = new TableNote();
        }
        public ITableNoteBuilder AddColumn(string columnsHeader)
        {
            if (tableNote.Rows.Count>0)
            {
                throw new Exception("Veri eklendikten sonra kolon eklenemez");
            }
            if (tableNote.Rows.Count>0)
            {
                foreach (List<string> item in tableNote.Rows)
                {
                    item.Add("No Data");
                }
            }
            tableNote.Columns.Add(columnsHeader);
            return this;
        }

        public ITableNoteBuilder AddRow(params string[] data)
        {
            if (data.Length!=tableNote.Columns.Count)
            {
                throw new Exception("Satır verileriyle kolon sayısı örtüşmüyor");
            }
            tableNote.Rows.Add(data.ToList());
            return this;
        }

        public Note Create()
        {
            return tableNote;
        }
        
        //public void AddRow(Dictionary<string,string> rowData)
        //{

        //}
    }
}
