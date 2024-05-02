using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask3_4
{
    public class FileSystemImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href)
        {
            return $"Loading image '{href}' from file system";
        }
    }
}
