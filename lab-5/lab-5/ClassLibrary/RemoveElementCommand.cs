using ClassLibraryForTask5_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RemoveElementCommand : ICommand
    {
        private LightNode _parent;
        private LightNode _element;

        public RemoveElementCommand(LightNode parent, LightNode element)
        {
            _parent = parent;
            _element = element;
        }

        public void Execute()
        {
            _parent.Children.Remove(_element);
        }

        public void Undo()
        {
            _parent.Children.Add(_element);
        }
    }
}
