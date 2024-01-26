using Odev_Lib;
using System;

namespace DesignPatternNOTEPAD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note textNote=NoteFactory.GetTextNote("Başlık 1")
            //                         .AddParagraph("Paragraf 1")
            //                         .AddParagraph("Paragraf 2") 
            //                         .Create();

            //Console.WriteLine(textNote.View());

            //------------------------------------------------------------------------------------------

            //Note tableNote = NoteFactory.GetTableNote()
            //                          .AddColumn("Ad")
            //                          .AddColumn("Soyad")
            //                          .AddRow("Burak", "Uğraş")
            //                          .AddRow("Cengiz", "Öder").Create();

            //Console.WriteLine(tableNote.View());

            //------------------------------------------------------------------------------------------

            Note listNote = NoteFactory.GetListNote()
                                     .IsOrdered(false)
                                     //.SetFormat(OrderedListTypes.Letter)
                                     .SetCharacter(UnorderedListTypes.Asteriks)
                                     .AddItem("item 1")
                                     .AddItem("item 2")
                                     .AddItem("item 3")
                                     .AddItem("item 4")
                                     .AddItem("item 5")
                                     .AddItem("item 1")
                                     .AddItem("item 2")
                                     .AddItem("item 3")
                                     .AddItem("item 4")
                                     .AddItem("item 5")
                                     .AddItem("item 4")
                                     .AddItem("item 5")
                                     .AddItem("item 1")
                                     .AddItem("item 2")
                                     .AddItem("item 3")
                                     .AddItem("item 4")
                                     .AddItem("item 5").Create();

            listNote.Color = TextColor.Blue;
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),listNote.Color.ToString());

            Console.WriteLine(listNote.View());

            Console.ReadKey();
        }
    }
}
