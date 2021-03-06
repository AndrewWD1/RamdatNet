﻿using System;
using System.Collections.Generic;

namespace RamdatNet
{
    public partial class R
    {
        public Func<IEnumerable<T>, IEnumerable<T>> Rejects<T>(Func<T, bool> fn)
            => Filter(R.Not(fn));
    }
}