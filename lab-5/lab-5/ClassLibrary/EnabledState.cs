using ClassLibraryForTask5_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EnabledState : IElementState
    {
        public void ApplyState(LightElementNode element)
        {
            element.CssClasses.Remove("disabled");
        }
    }
}
