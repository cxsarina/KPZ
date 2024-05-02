using ClassLibraryForTask5_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DisabledState : IElementState
    {
        public void ApplyState(LightElementNode element)
        {
            element.CssClasses.Add("disabled");
        }
    }
}
