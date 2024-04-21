namespace ClassLibraryForTask5
{
    public class TextDocument
    {
        private string _text;
        private Stack<string> _history;

        public TextDocument()
        {
            _text = string.Empty;
            _history = new Stack<string>();
        }

        public string Text
        {
            get { return _text; }
            set
            {
                _history.Push(_text);
                _text = value;
            }
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                _text = _history.Pop();
            }
        }
    }
}
