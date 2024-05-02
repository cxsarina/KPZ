using ClassLibrary;

namespace ClassLibraryForTask5_6
{
    public abstract class LightNode
    {
       
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }
        public event EventHandler<string> Click;
        public List<LightNode> Children { get; set; }
        public abstract void Accept(IHtmlVisitor visitor);

        public LightNode()
        {
            Children = new List<LightNode>();
        }
        protected void OnClick(string message)
        {
            Click?.Invoke(this, message);
        }
        public virtual void OnCreated()
        {
            Console.WriteLine($"Node created: {GetType().Name}");
        }

        public virtual void OnInserted()
        {
            Console.WriteLine($"Node inserted: {GetType().Name}");
        }

        public virtual void OnRemoved()
        {
            Console.WriteLine($"Node removed: {GetType().Name}");
        }

        public virtual void OnStylesApplied()
        {
            Console.WriteLine($"Styles applied to node: {GetType().Name}");
        }

        public virtual void OnClassListApplied()
        {
            Console.WriteLine($"Classes applied to node: {GetType().Name}");
        }

        public virtual void OnTextRendered()
        {
            Console.WriteLine($"Text rendered for node: {GetType().Name}");
        }
    }
}
