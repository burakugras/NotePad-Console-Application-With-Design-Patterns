using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    class TableNote : Note
    {
        public List<string> Columns { get; set; }
        public List<List<string>> Rows { get; set; }
        public TableNote()
        {
            Columns = new List<string>();
            Rows = new List<List<string>>();
        }
        public override string View()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string item in Columns)
            {
                stringBuilder.Append($"{item}\t");
            }
            stringBuilder.AppendLine();
            foreach (List<string> row in Rows)
            {
                foreach (string item in row)
                {
                    stringBuilder.Append($"{item}\t");
                }
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }
    }
}
