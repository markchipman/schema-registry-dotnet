﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemaRegistry.Messages
{
    public enum CompatibilityLevel
    {
        None,
        Fill,
        Forward,
        Backward
    }
}
