using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask3_4
{
    public interface IImageLoadingStrategy
    {
        string LoadImage(string href);
    }
}
