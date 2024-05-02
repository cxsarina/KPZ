using ClassLibraryForTask5_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DepthFirstIterator : IHtmlIterator
    {
        private Stack<LightNode> stack;

        public DepthFirstIterator(LightNode root)
        {
            stack = new Stack<LightNode>();
            stack.Push(root);
        }

        public LightNode GetNext()
        {
            if (!HasNext())
                return null;

            var node = stack.Pop();

            if (node is LightElementNode elementNode)
            {
                for (int i = elementNode.Children.Count - 1; i >= 0; i--)
                {
                    stack.Push(elementNode.Children[i]);
                }
            }

            return node;
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }
    }
}
