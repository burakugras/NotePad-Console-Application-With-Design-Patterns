using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    class TextNote : Note
    {
        public TextNote(string header)
        {
            header = header;
            Paragraphs = new List<string>();
        }
        public string Header { get; set; }
        public List<string> Paragraphs { get; set; }

        public override string View()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Header);
            foreach (string item in Paragraphs)
            {
                stringBuilder.AppendLine(item);
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }
    }
}
