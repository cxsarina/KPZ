namespace ClassLibraryForTask5_6
{
    public abstract class LightNode
    {
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }
        public event EventHandler<string> Click;

        protected void OnClick(string message)
        {
            Click?.Invoke(this, message);
        }
    }
}
