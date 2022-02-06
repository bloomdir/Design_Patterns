using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2.Formats
{
    internal interface IFormate
    {
        void CreateDocument();
        void OpenDocument();
        void CloseDocument();
        void WriteDocument(string text, WdParagraphAlignment pos, int size, int bold, string font);
        void SaveDocument();
        void CloseApp();
    }
}
