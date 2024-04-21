using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask5
{
    public class TextEditor
    {
        private TextDocument _document;

        public TextEditor()
        {
            _document = new TextDocument();
        }

        public void SetText(string text)
        {
            _document.Text = text;
        }

        public string GetText()
        {
            return _document.Text;
        }

        public void Save()
        {
            Console.WriteLine("Document saved.");
        }

        public void Undo()
        {
            _document.Undo();
        }
    }
}
