using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeMi.Core.Entries
{
    internal interface IContainer
    {
        Entry GetContent(bool isFreeboxV5);
    }
}