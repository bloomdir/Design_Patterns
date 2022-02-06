using Microsoft.Office.Interop.Word;
using Strategy2.Formats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    // Гост заголовка: Заголовок должен быть расположен по середине и быть размером 25px и выделен жирным, шрифт open sans
    // Гост текста: текст выровнен по левому краю, шрифт arial
    internal class DocumentClass
    {
        string head_str;
        string text_str;
        string choise;
        IFormate doc_formate;
        public DocumentClass(string _head_str, string _text_str, string _choise)
        {
            head_str = _head_str;
            text_str = _text_str;   
            choise = _choise;            
        }
        public void Start()
        {
            switch(choise)
            {
                case "1":
                    doc_formate = new WordClass();
                    break;
                case "2":
                    /// ну бля мне в падлу в pdf копаться, тем более ненавижу его.
                    /// но все тож самое по аналогии как с case 1
                    /// типо
                    /// doc_formate = new AdobeReaderClass();
                    break;
            }
            if (doc_formate != null)
            {
                doc_formate.CreateDocument();
                doc_formate.WriteDocument(head_str, WdParagraphAlignment.wdAlignParagraphCenter, 25, 10, "Century Gothic");
                doc_formate.WriteDocument(text_str, WdParagraphAlignment.wdAlignParagraphLeft, 15, 1, "Arial");
                doc_formate.SaveDocument();
                doc_formate.CloseDocument();
                doc_formate.CloseApp();
            }

        }
    }
}
