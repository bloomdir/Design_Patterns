using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace Strategy2.Formats
{
    internal class WordClass : IFormate
    {
        string path;
        Word.Application word_app;
        Word.Document word_doc;

        public WordClass()
        {
            path = Directory.GetCurrentDirectory() + "\\doc1.docx";
            word_app = new Word.Application();
            word_app.Visible = false;            
        }

        public void CreateDocument()
        {
            word_doc = word_app.Documents.Add(Type.Missing, false, Word.WdNewDocumentType.wdNewBlankDocument, false);
            SaveDocument();            
        }
        public void CloseDocument()
        {
            word_doc.Close();
            word_doc=null;
        }

        public void OpenDocument()
        {
            word_doc = word_app.Documents.Open(path);
        }

        public void SaveDocument()
        {
            word_doc.SaveAs2(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing);
        }

        public void WriteDocument(string text, WdParagraphAlignment pos, int size, int bold, string font)
        {
            Paragraph word_paragraph;
            word_doc.Content.Paragraphs.Add();
            int count = word_doc.Content.Paragraphs.Count;
            word_paragraph = word_doc.Content.Paragraphs[count];
            word_paragraph.Range.Text = text;
            word_paragraph.Range.Paragraphs.Alignment = pos;
            word_paragraph.Range.Font.Size = size;
            word_paragraph.Range.Bold = bold;
            word_paragraph.Range.Font.Name = font;
            word_doc.Save();
        }
        public void CloseApp()
        {
            word_app.Quit();
        }
    }
}
