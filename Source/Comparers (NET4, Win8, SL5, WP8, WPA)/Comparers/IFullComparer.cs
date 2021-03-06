﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comparers
{
    /// <summary>
    /// A non-generic comparer that also provides equality comparison (and hash codes).
    /// </summary>
    public interface IFullComparer : IComparer, IEqualityComparer
    {
    }
}
