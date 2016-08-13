﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeMi.Core.Entries
{
    internal interface IMedia
    {
        MediaKind? MediaKind { get; }
        string Path { get; set; }
        bool UsePathAsId { get; set; }
    }
}