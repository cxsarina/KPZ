﻿using ClassLibraryForTask5_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IHtmlIterator
    {
        LightNode GetNext();
        bool HasNext();
    }
}
