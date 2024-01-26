using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Lib
{
    class ListNote : Note
    {
        public bool IsOrdered { get; set; }
        public char ListType { get; set; }
        public List<string> Items { get; set; }
        public ListNote()
        {
            Items = new List<string>();
        }
        public override string View()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (IsOrdered && ListType=='1')
            {
                int number = int.Parse(ListType.ToString());
                foreach (string item in Items)
                {
                    stringBuilder.AppendLine($"{number}. {item}");
                    number++;
                }
            }
            else if (IsOrdered)
            {
                foreach (string item in Items)
                {
                    stringBuilder.AppendLine($"{ListType}. {item}");
                    ListType++;
                }
            }
            else
            {
                foreach (string item in Items)
                {
                    stringBuilder.AppendLine($"{ListType} {item}");
                }
            }

            return stringBuilder.ToString();
        }
    }
}
